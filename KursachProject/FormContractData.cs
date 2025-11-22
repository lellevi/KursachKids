using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using KursachProject.Models;


namespace KursachProject
{
    public partial class FormContractData : Form
    {
        private readonly string _connectionString;
        private DataTable _dataTable;

        public FormContractData(string connectionString)
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
                    string query = "SELECT [ContractData].[start_date], [ContractData].[end_date], [KidsData].[name], [KidsData].[surname], [ParentsData].[name], [ParentsData].[middle_name] FROM ([KidsData] INNER JOIN [ContractData] ON [KidsData].[kid_id] = [ContractData].[kid_id]) INNER JOIN [ParentsData] ON [KidsData].[kid_id] = [ParentsData].[kid_id];"; OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                    _dataTable = new DataTable();
                    adapter.Fill(_dataTable);


                    dataGridView1.DataSource = _dataTable;

                    dataGridView1.Columns[0].HeaderText = "Дата начала";
                    dataGridView1.Columns[1].HeaderText = "Дата окончания";
                    dataGridView1.Columns[2].HeaderText = "Имя ребёнка";
                    dataGridView1.Columns[3].HeaderText = "Фамилия ребёнка";
                    dataGridView1.Columns[4].HeaderText = "Имя матери";
                    dataGridView1.Columns[5].HeaderText = "Имя отца";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения: " + ex.Message);
            }
        }
        private void buttonDownLoad1_Click(object sender, EventArgs e)
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
                    _dataTable.Rows.Add("10.10.2025", "10.10.2025",selectedValue, selectedID, "Болезнь");

                    MessageBox.Show($"Выбранный ID: {selectedID}, Значение: {selectedValue}");
                }
            }
           
        }

        private void buttonArrRow_Click(object sender, EventArgs e)
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
                dataGridView1.Rows[index].Cells[5].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
            }
            /*      dataGridView1.Columns[0].HeaderText = "Дата начала";
                    dataGridView1.Columns[1].HeaderText = "Дата окончания";
                    dataGridView1.Columns[2].HeaderText = "Имя ребёнка";
                    dataGridView1.Columns[3].HeaderText = "Фамилия ребёнка";
                    dataGridView1.Columns[4].HeaderText = "Имя матери";
                    dataGridView1.Columns[5].HeaderText = "Имя отца";
            */
            //генерируется string contract_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string start_date = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string end_date = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string kid_id = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string mom_id = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string father_id = dataGridView1.Rows[index].Cells[5].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = $"INSERT INTO ContractData VALUES ({start_date},{end_date},{kid_id},{mom_id},{father_id})";
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
                dataGridView1.Rows[index].Cells[5].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
            }
            string contract_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string start_date = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string end_date = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string kid_id = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string mom_id = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string father_id = dataGridView1.Rows[index].Cells[5].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = $"UPDATE ContractData SET start_date={start_date},end_date={end_date},kid_id={kid_id},mom_id={mom_id},father_id={father_id} WHERE contract_id ={contract_id}"; 
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
            string contract_id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = "DELETE FROM ContractData WHERE contract_id = " + contract_id;
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
