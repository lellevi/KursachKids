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
    public partial class GroupDataForMentors : Form
    {
        private readonly string _connectionString;

        public GroupDataForMentors(string connectionString)
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
