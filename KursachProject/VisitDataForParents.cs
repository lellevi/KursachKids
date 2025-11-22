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
using ZedGraph;

namespace KursachProject
{
    public partial class VisitDataForParents : Form
    {
        private readonly string _connectionString;

        public VisitDataForParents(string connectionString)
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
                    string query = @"
                    SELECT 
                        VisitData.note_id,
                        VisitData.kid_id,
                        KidsData.surname  + ' ' + KidsData.name + ' ' + KidsData.middle_name AS FullName,
                        VisitData.date,
                        VisitData.cause
                    FROM VisitData
                    INNER JOIN KidsData 
                    ON VisitData.kid_id = KidsData.kid_id";//буквальная строка
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns[0].HeaderText = "ID записи";
                    dataGridView1.Columns[1].HeaderText = "ID ребёнка";
                    dataGridView1.Columns[2].HeaderText = "Дата";
                    dataGridView1.Columns[3].HeaderText = "Причина";

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
