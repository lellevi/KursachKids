using KursachProject.Models;
using KursachProject.Repositories;
using Newtonsoft.Json;
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
using System.Xml.Linq;

namespace KursachProject
{
    public partial class FormGroupData : Form
    {
        private readonly string _connectionString;
        private readonly GroupSqlRepository _repository;

        public FormGroupData(string connectionString)
        {
            _connectionString = connectionString;
            _repository = new GroupSqlRepository(_connectionString);

            try
            {
                var createdId = _repository.Create(new GroupData 
                { 
                    NameOfGroup = "123",
                    MentorId = 1,
                    CountOfKids = 15, 
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

                    string query = "SELECT [GroupData].[name_of_group], [GroupData].[count_of_kids], [MentorsData].[surname], [MentorsData].[name], [MentorsData].[middle_name], [MentorsData].[telephone] FROM [GroupData] INNER JOIN [MentorsData] ON [GroupData].[group_id] = [MentorsData].[group_id];";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns[0].HeaderText = "Название группы";
                    dataGridView1.Columns[1].HeaderText = "Количество детей";
                    dataGridView1.Columns[2].HeaderText = "Фамилия воспитателя";
                    dataGridView1.Columns[3].HeaderText = "Имя воспитателя ";
                    dataGridView1.Columns[4].HeaderText = "Отчество воспитателя";
                    dataGridView1.Columns[5].HeaderText = "Телефон воспитателя";


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

                    string query = "SELECT [GroupData.name_of_group], [GroupData.count_of_kids], [MentorsData.surname], [MentorsData.name], [MentorsData.middle_name], [MentorsData.telephone] FROM [GroupData] INNER JOIN [MentorsData] ON [GroupData.group_id] = [MentorsData.group_id];";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns[0].HeaderText = "Название группы";
                    dataGridView1.Columns[1].HeaderText = "Количество детей";
                    dataGridView1.Columns[2].HeaderText = "Фамилия воспитателя";
                    dataGridView1.Columns[3].HeaderText = "Имя воспитателя ";
                    dataGridView1.Columns[4].HeaderText = "Отчество воспитателя";
                    dataGridView1.Columns[5].HeaderText = "Телефон воспитателя";

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
                dataGridView1.Rows[index].Cells[2].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
            }
            string group_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string mentor_id = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string count_of_kids = dataGridView1.Rows[index].Cells[2].Value.ToString();
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
                dataGridView1.Rows[index].Cells[2].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
            }
            string group_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string mentor_id = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string count_of_kids = dataGridView1.Rows[index].Cells[2].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = $"UPDATE GroupData SET group_id={group_id},mentor_id={mentor_id},count_of_kids={count_of_kids}"; 

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
            string group_id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = "DELETE FROM GroupData WHERE group_id = " + group_id;
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
