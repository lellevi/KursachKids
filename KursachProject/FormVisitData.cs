using KursachProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace KursachProject
{
    public partial class FormVisitData : Form
    {
        private readonly string _connectionString;
        private DataTable _dataTable;

        public FormVisitData(string connectionString)
        {
            _connectionString = connectionString;
            InitializeComponent();
            Download();
        }
        private void Download()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
                    SELECT 
                        VisitData.note_id,
                        VisitData.kid_id,
                        KidsData.surname  + ' ' + KidsData.name + ' ' + KidsData.middle_name AS FullName,
                        VisitData.date,
                        VisitData.cause
                    FROM VisitData
                    INNER JOIN KidsData 
                    ON VisitData.kid_id = KidsData.kid_id";//буквальная строка
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    _dataTable = new DataTable();
                    adapter.Fill(_dataTable);


                    dataGridView1.DataSource = _dataTable;

                    dataGridView1.Columns[0].HeaderText = "ID записи";
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].HeaderText = "ID ребёнка";
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[2].HeaderText = "ФИО ребёнка";
                    dataGridView1.Columns[3].HeaderText = "Дата";
                    dataGridView1.Columns[4].HeaderText = "Причина";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
        }
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            Download();

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<ComboBoxItem> kidsList = new List<ComboBoxItem>();

            try
            {
                using (OleDbConnection connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();

                    string kidsQuery = "SELECT kid_id, surname, name, middle_name FROM KidsData";
                    OleDbCommand command = new OleDbCommand(kidsQuery, connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string surname = reader.GetString(1);
                        string name = reader.GetString(2);
                        string middleName = reader.GetString(3);

                        string fullName = $"{surname} {name} {middleName}";
                        kidsList.Add(new ComboBoxItem { ID = id, Name = fullName });
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }

            using (DropdownEditForm formChild = new DropdownEditForm("Выберите ребёнка", kidsList))
            {
                if (formChild.ShowDialog() == DialogResult.OK)
                {
                    int selectedID = formChild.SelectedID;
                    string selectedValue = formChild.SelectedValue;
                    _dataTable.Rows.Add(0,selectedID, selectedValue,"12.12.2000","");//!!!!!

                    MessageBox.Show($"Выбранный ID: {selectedID}, Значение: {selectedValue}");
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }
            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
            }
           
            string note_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string kid_id = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string date = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string cause = dataGridView1.Rows[index].Cells[4].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = $"UPDATE VisitData SET kid_id={kid_id},date={date},cause='{cause}' WHERE note_id={note_id}"; 
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//команда

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка");
            else
                MessageBox.Show("Данные обновлены!", "Внимание!");

            dbConnection.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Проверяем кол-во выбранных строк
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }
            //запомним выбранную строку
            int index = dataGridView1.SelectedRows[0].Index;

            //проверяем данные таблицы  
            if (dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
            }
            //тут считываем данные. Для удаления хватит только айди
            string note_id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);//создаем соединение

            //запрос
            dbConnection.Open();//открываем соединение
            string query = "DELETE FROM VisitData WHERE note_id = " + note_id;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//команда

            //выполняем запрос
            if (dbCommand.ExecuteNonQuery() != 1)//туда мы отправляем одну строку данных, нам возвращается количество добавленных данных
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка");
            else
            {
                MessageBox.Show("Данные удалены!", "Внимание!");
                dataGridView1.Rows.RemoveAt(index);
            }
            //закрываем соединение
            dbConnection.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGenerateChart_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;

            if (!DateTime.TryParse(textBoxStartDate.Text, out startDate) ||
                !DateTime.TryParse(textBoxEndDate.Text, out endDate))
            {
                MessageBox.Show("Ошибка: введите корректные даты.");
                return;
            }

            var attendanceData = GetAttendanceData(startDate, endDate);

            PlotAttendanceChart(attendanceData);
        }
        private DataTable GetAttendanceData(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();


            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT date, COUNT(*) as Absences FROM VisitData WHERE date >= @startDate AND date <= @endDate GROUP BY date";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        private void PlotAttendanceChart(DataTable attendanceData)
        {
            GraphPane graphPane = zedGraphControl.GraphPane;
            graphPane.Title.Text = "Посещаемость детей";
            graphPane.YAxis.Title.Text = "Количество пропусков";

            graphPane.CurveList.Clear();

            PointPairList pointList = new PointPairList();
            List<string> xLabels = new List<string>();

            foreach (DataRow row in attendanceData.Rows)
            {
                DateTime date = (DateTime)row["date"];
                int absences = (int)row["Absences"];
                pointList.Add(new XDate(date), absences);
                xLabels.Add(date.ToString("dd.MM"));
            }

            BarItem myCurve = graphPane.AddBar("Пропуски", pointList, System.Drawing.Color.Green);

            graphPane.YAxis.Scale.Min = 0;
            graphPane.YAxis.Scale.MajorStep = 1;
            graphPane.YAxis.Scale.Max = attendanceData.AsEnumerable().Max(row => (int)row["Absences"]) + 1;

            graphPane.XAxis.Type = AxisType.Date;
            graphPane.XAxis.Scale.Format = "dd.MM";
            graphPane.XAxis.Scale.MajorStep = 1;

            graphPane.XAxis.MajorTic.IsBetweenLabels = true; //отображение основных делений
            graphPane.XAxis.MajorTic.Size = 5;
            graphPane.XAxis.MajorTic.Color = System.Drawing.Color.Black;
            graphPane.XAxis.MajorTic.IsOutside = true;
            graphPane.XAxis.MajorTic.IsOpposite = false;

            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }
            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null ||
                dataGridView1.Rows[index].Cells[4].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
            }
            string kid_id = dataGridView1.Rows[index].Cells[1].Value.ToString();

            string date = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string cause = dataGridView1.Rows[index].Cells[4].Value.ToString();

            if (!DateTime.TryParse(date, out DateTime dateValue))
            {
                MessageBox.Show("Неверный формат даты!", "Ошибка");
                return;
            }

            string accessDate = dateValue.ToString("dd.MM.yyyy");

            try
            {
                using (OleDbConnection connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    string query = $"INSERT INTO [VisitData] ([kid_id], [date], [cause]) VALUES ({kid_id}, '{accessDate}', '{cause}')";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Ошибка выполнения запроса!", "Ошибка");
                    else
                        MessageBox.Show("Данные добавлены!", "Внимание!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
            
        }
    }
}
