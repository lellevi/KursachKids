using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachProject
{
    public partial class MenuMentor : Form
    {
        private readonly string _connectionString;
        public MenuMentor(string connectionString)
        {
            _connectionString = connectionString;
            InitializeComponent();
        }
        private void buttonAboutChildren_Click(object sender, EventArgs e)
        {
            Visible = false;
            new KidsDataForMentors(_connectionString).ShowDialog();
        }
        private void buttonAboutGroups_Click(object sender, EventArgs e)
        {
            Visible = false;
            new GroupDataForMentors(_connectionString).ShowDialog();
        }
        private void buttonAboutPayment_Click(object sender, EventArgs e)
        {
            Visible = false;
            new PaymentDataForMentors(_connectionString).ShowDialog();
        }
        private void buttonContractData_Click(object sender, EventArgs e)
        {
            Visible = false;
            new ContractDataForMentors(_connectionString).ShowDialog();
        }
        private void buttonVisitData_Click(object sender, EventArgs e)
        {
            Visible = false;
            new VisitDataForMentors(_connectionString).ShowDialog();
        }
        private void buttonParentData_Click(object sender, EventArgs e)
        {
            Visible = false;
            new ParentDataForMentors(_connectionString).ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
