using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachProject
{
    public partial class FormMentorData : Form
    {
        private readonly string _connectionString;

        public FormMentorData(string connectionString)
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
                    string query = "SELECT [MentorsData].[surname], [MentorsData].[name], [MentorsData].[middle_name], [MentorsData].[date_of_birth], [MentorsData].[telephone], [MentorsData].[work_experience], [GroupData].[name_of_group] FROM [GroupData] INNER JOIN [MentorsData] ON [GroupData].[group_id] = [MentorsData].[group_id];";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns[0].HeaderText = "Фамилия";
                    dataGridView1.Columns[1].HeaderText = "Имя";
                    dataGridView1.Columns[2].HeaderText = "Отчество";
                    dataGridView1.Columns[3].HeaderText = "Дата рождения";
                    dataGridView1.Columns[4].HeaderText = "Телефон";
                    dataGridView1.Columns[5].HeaderText = "Стаж";
                    dataGridView1.Columns[6].HeaderText = "Название группы";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {



            try
            {
                using (OleDbConnection connection = new OleDbConnection(_connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Подключение успешно!");

                    string query = "SELECT [MentorsData.surname], [MentorsData.name], [MentorsData.middle_name], [MentorsData.date_of_birth], [MentorsData.telephone], [MentorsData.work_experience], [GroupData.name_of_group] FROM [GroupData] INNER JOIN [MentorsData] ON [GroupData.group_id] = [MentorsData.group_id];";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns[0].HeaderText = "Фамилия";
                    dataGridView1.Columns[1].HeaderText = "Имя";
                    dataGridView1.Columns[2].HeaderText = "Отчество";
                    dataGridView1.Columns[3].HeaderText = "Дата рождения";
                    dataGridView1.Columns[4].HeaderText = "Телефон";
                    dataGridView1.Columns[5].HeaderText = "Стаж";
                    dataGridView1.Columns[6].HeaderText = "Название группы";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
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
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null ||
                dataGridView1.Rows[index].Cells[7].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
            }
            string mentor_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string group_id = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string surname = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string name = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string middle_name = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string date_of_birth = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string telephone = dataGridView1.Rows[index].Cells[6].Value.ToString();
            string work_experience = dataGridView1.Rows[index].Cells[7].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = $"INSERT INTO MentorsData VALUES ({mentor_id},{group_id},'{surname}','{name}','{middle_name}','{date_of_birth}','{telephone}',{work_experience})";

            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка");
            else
                MessageBox.Show("Данные добавлены!", "Внимание!");
            dbConnection.Close();
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
                dataGridView1.Rows[index].Cells[4].Value == null ||
                dataGridView1.Rows[index].Cells[5].Value == null ||
                dataGridView1.Rows[index].Cells[6].Value == null ||
                dataGridView1.Rows[index].Cells[7].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
            }
            string mentor_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string group_id = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string surname = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string name = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string middle_name = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string date_of_birth = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string telephone = dataGridView1.Rows[index].Cells[6].Value.ToString();
            string work_experience = dataGridView1.Rows[index].Cells[7].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = $"UPDATE MentorsData SET group_id={group_id},surname='{surname}',name='{name}',middle_name='{middle_name}',date_of_birth='{date_of_birth}',telephone='{telephone}',work_experience={work_experience} WHERE mentor_id={mentor_id}";

            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка");
            else
                MessageBox.Show("Данные обновлены!", "Внимание!");
            dbConnection.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }
            int index = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
            }
            string mentor_id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = "DELETE FROM MentorsData WHERE mentor_id = " + mentor_id;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка");
            else
            {
                MessageBox.Show("Данные удалены!", "Внимание!");
                dataGridView1.Rows.RemoveAt(index);
            }
            dbConnection.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}