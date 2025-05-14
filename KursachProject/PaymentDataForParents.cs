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
    public partial class PaymentDataForParents : Form
    {
        private readonly string _connectionString;

        public PaymentDataForParents(string connectionString)
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

                    string query = "SELECT [PaymentData].[payment_amount], [PaymentData].[type], [PaymentData].[date], [KidsData].[surname], [KidsData].[name], [GroupData].[name_of_group] FROM [GroupData] INNER JOIN ([KidsData] INNER JOIN ([ContractData] INNER JOIN [PaymentData] ON [ContractData].[contract_id] = [PaymentData].[contract_id]) ON [KidsData].[kid_id] = [ContractData].[kid_id]) ON [GroupData].[group_id] = [KidsData].[group_id];"; 
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
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
