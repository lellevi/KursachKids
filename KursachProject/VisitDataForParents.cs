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

        private void buttonGenerateChart_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;

            if (!DateTime.TryParse(textBoxStartDate.Text, out startDate) ||
                !DateTime.TryParse(textBoxEndDate.Text, out endDate))
            {
                MessageBox.Show("Ошибка: введите корректные даты.");
                return;
            }

            var attendanceData = GetAttendanceData(startDate, endDate);

            PlotAttendanceChart(attendanceData);
        }
        private DataTable GetAttendanceData(DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();


            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT date, COUNT(*) as Absences FROM VisitData WHERE date >= @startDate AND date <= @endDate GROUP BY date";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        private void PlotAttendanceChart(DataTable attendanceData)
        {
            GraphPane graphPane = zedGraphControl.GraphPane;
            graphPane.Title.Text = "Посещаемость детей";
            graphPane.YAxis.Title.Text = "Количество пропусков";

            graphPane.CurveList.Clear();

            PointPairList pointList = new PointPairList();
            List<string> xLabels = new List<string>();

            foreach (DataRow row in attendanceData.Rows)
            {
                DateTime date = (DateTime)row["date"];
                int absences = (int)row["Absences"];
                pointList.Add(new XDate(date), absences);
                xLabels.Add(date.ToString("dd.MM"));
            }

            BarItem myCurve = graphPane.AddBar("Пропуски", pointList, System.Drawing.Color.Green);

            graphPane.YAxis.Scale.Min = 0;
            graphPane.YAxis.Scale.MajorStep = 1;
            graphPane.YAxis.Scale.Max = attendanceData.AsEnumerable().Max(row => (int)row["Absences"]) + 1;

            graphPane.XAxis.Type = AxisType.Date;
            graphPane.XAxis.Scale.Format = "dd.MM";
            graphPane.XAxis.Scale.MajorStep = 1;

            graphPane.XAxis.MajorTic.IsBetweenLabels = true; 
            graphPane.XAxis.MajorTic.Size = 5;
            graphPane.XAxis.MajorTic.Color = System.Drawing.Color.Black;
            graphPane.XAxis.MajorTic.IsOutside = true;
            graphPane.XAxis.MajorTic.IsOpposite = false;

            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }
    }
}
