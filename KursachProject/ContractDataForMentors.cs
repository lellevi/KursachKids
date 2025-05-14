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
    public partial class ContractDataForMentors : Form
    {
        private readonly string _connectionString;
        public ContractDataForMentors(string connectionString)
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
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

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
       
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
