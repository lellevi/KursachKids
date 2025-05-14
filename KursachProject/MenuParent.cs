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
    public partial class MenuParent : Form
    {
        private readonly string _connectionString;
        public MenuParent(string connectionString)
        {
            _connectionString = connectionString;
            InitializeComponent();
        }
        private void buttonAboutGroups_Click(object sender, EventArgs e)
        {
            Visible = false;
            new GroupDataForParents(_connectionString).ShowDialog();
        }
        private void buttonAboutPayment_Click(object sender, EventArgs e)
        {
            Visible = false;
            new PaymentDataForParents(_connectionString).ShowDialog();
        }
        private void buttonAboutMentors_Click(object sender, EventArgs e)
        {
            Visible = false;
            new MentorDataForParents(_connectionString).ShowDialog();
        }
        private void buttonVisitData_Click(object sender, EventArgs e)
        {
            Visible = false;
            new VisitDataForParents(_connectionString).ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
