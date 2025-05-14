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
    public partial class MentorDataForParents : Form
    {
        private readonly string _connectionString;
        public MentorDataForParents(string connectionString)
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
