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
    public partial class ParentDataForMentors : Form
    {
        private readonly string _connectionString;
        public ParentDataForMentors(string connectionString)
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
                    string query = "SELECT [ParentsData].[surname], [ParentsData].[name], [ParentsData].[middle_name], [ParentsData].[date_of_birth], [ParentsData].[address], [ParentsData].[telephone], [ParentsData].[place_of_work], [KidsData].[name] FROM [KidsData] INNER JOIN [ParentsData] ON [KidsData].[kid_id] = [ParentsData].[kid_id];"; 
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    dataGridView1.Columns[0].HeaderText = "Фамилия";
                    dataGridView1.Columns[1].HeaderText = "Имя";
                    dataGridView1.Columns[2].HeaderText = "Отчество";
                    dataGridView1.Columns[3].HeaderText = "Дата рождения";
                    dataGridView1.Columns[4].HeaderText = "Адресс";
                    dataGridView1.Columns[5].HeaderText = "Телефон";
                    dataGridView1.Columns[6].HeaderText = "Место работы";
                    dataGridView1.Columns[7].HeaderText = "Имя ребёнка";
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
