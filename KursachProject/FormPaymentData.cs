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
    public partial class FormPaymentData : Form
    {
        private readonly string _connectionString;

        public FormPaymentData(string connectionString)
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

                    string query = "SELECT [PaymentData].[payment_amount], [PaymentData].[type], [PaymentData].[date], [KidsData].[surname], [KidsData].[name], [GroupData].[name_of_group] FROM [GroupData] INNER JOIN ([KidsData] INNER JOIN ([ContractData] INNER JOIN [PaymentData] ON [ContractData].[contract_id] = [PaymentData].[contract_id]) ON [KidsData].[kid_id] = [ContractData].[kid_id]) ON [GroupData].[group_id] = [KidsData].[group_id];"; OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns[0].HeaderText = "Стоимость";
                    dataGridView1.Columns[1].HeaderText = "Тип платежа";
                    dataGridView1.Columns[2].HeaderText = "Дата";
                    dataGridView1.Columns[3].HeaderText = "Фамилия ребёнка";
                    dataGridView1.Columns[4].HeaderText = "Имя ребёнка";
                    dataGridView1.Columns[5].HeaderText = "Название группы";

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

                    string query = "SELECT [PaymentData.payment_amount], [PaymentData.type], [PaymentData.date], [KidsData.surname], [KidsData.name], [GroupData.name_of_group] FROM [GroupData] INNER JOIN ([KidsData] INNER JOIN ([ContractData] INNER JOIN [PaymentData] ON [ContractData.contract_id] = [PaymentData.contract_id]) ON [KidsData.kid_id] = [ContractData.kid_id]) ON [GroupData.group_id] = [KidsData.group_id];";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns[0].HeaderText = "Стоимость";
                    dataGridView1.Columns[1].HeaderText = "Тип платежа";
                    dataGridView1.Columns[2].HeaderText = "Дата";
                    dataGridView1.Columns[3].HeaderText = "Фамилия ребёнка";
                    dataGridView1.Columns[4].HeaderText = "Имя ребёнка";
                    dataGridView1.Columns[5].HeaderText = "Название группы";
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
                dataGridView1.Rows[index].Cells[4].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
            }
            string payment_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string contract_id = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string payment_amount = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string type = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string date = dataGridView1.Rows[index].Cells[4].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = $"INSERT INTO PaymentData VALUES ({payment_id},{contract_id},{payment_amount},'{type}',{date})";

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
                dataGridView1.Rows[index].Cells[4].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
            }
            string payment_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string contract_id = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string payment_amount = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string type = dataGridView1.Rows[index].Cells[3].Value.ToString();
            string date = dataGridView1.Rows[index].Cells[4].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = $"UPDATE PaymentData SET contract_id={contract_id},payment_amount={payment_amount},type='{type}',date{date} WHERE payment_id = {payment_id}";
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
            string payment_id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            OleDbConnection dbConnection = new OleDbConnection(_connectionString);

            dbConnection.Open();
            string query = "DELETE FROM PaymentData WHERE payment_id = " + payment_id;
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