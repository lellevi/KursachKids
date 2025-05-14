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

namespace KursachProject
{
    public partial class FormKids : Form
    {
        private readonly string _connectionString;

        public FormKids(string connectionString)
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
                    string query = "SELECT [KidsData].[surname], [KidsData].[name], [KidsData].[middle_name], [KidsData].[date_of_birth], [KidsData].[gender], [GroupData].[name_of_group] FROM [GroupData] INNER JOIN [KidsData] ON [GroupData].[group_id] = [KidsData].[group_id];"; OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Фамилия";
                    dataGridView1.Columns[1].HeaderText = "Имя";
                    dataGridView1.Columns[2].HeaderText = "Отчество";
                    dataGridView1.Columns[3].HeaderText = "Дата рождения";
                    dataGridView1.Columns[4].HeaderText = "Пол";
                    dataGridView1.Columns[5].HeaderText = "Название группы";
                    connection.Close();
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

                    string query = "SELECT [KidsData.surname], [KidsData.name], [KidsData.middle_name], [KidsData.date_of_birth], [KidsData.gender], [GroupData.name_of_group] FROM [GroupData] INNER JOIN [KidsData] ON [GroupData.group_id] = [KidsData.group_id];";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "Фамилия";
                    dataGridView1.Columns[1].HeaderText = "Имя";
                    dataGridView1.Columns[2].HeaderText = "Отчество";
                    dataGridView1.Columns[3].HeaderText = "Дата рождения";
                    dataGridView1.Columns[4].HeaderText = "Пол";
                    dataGridView1.Columns[5].HeaderText = "Название группы";
                    connection.Close();
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
                dataGridView1.Rows[index].Cells[6].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
            }

            string kid_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string surname = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string name = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string middle_name = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string date_of_birth = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string group_id = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string gender = dataGridView1.Rows[index].Cells[6].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = $"INSERT INTO KidsData VALUES ({kid_id},'{surname}','{name}','{middle_name}','{date_of_birth}',{group_id},'{gender}')";

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
                dataGridView1.Rows[index].Cells[6].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
            }

            string kid_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string surname = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string name = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string middle_name = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string date_of_birth = dataGridView1.Rows[index].Cells[4].Value.ToString();
            string group_id = dataGridView1.Rows[index].Cells[5].Value.ToString();
            string gender = dataGridView1.Rows[index].Cells[6].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = $"UPDATE KidsData SET surname='{surname}', name='{name}', middle_name='{middle_name}', date_of_birth='{date_of_birth}', group_id={group_id}, gender='{gender}' WHERE kid_id={kid_id}";
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
            string kid_id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = $"DELETE FROM KidsData WHERE kid_id={kid_id}";
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