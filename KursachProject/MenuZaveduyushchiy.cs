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
    public partial class MenuZaveduyushchiy : Form
    {
        private readonly string _connectionString;
        public MenuZaveduyushchiy(string connectionString)
        {
            _connectionString = connectionString;
            InitializeComponent();

        }
        private void buttonAboutChildren_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FormKids(_connectionString).ShowDialog();
            Visible = true;
        }
        private void buttonAboutGroups_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FormGroupData(_connectionString).ShowDialog();
            Visible = true;
        }
        private void buttonAboutPayment_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FormPaymentData(_connectionString).ShowDialog();
            Visible = true;
        }
        private void buttonAboutMentors_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FormMentorData(_connectionString).ShowDialog();
            Visible = true;

        }
        private void buttonContractData_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FormContractData(_connectionString).ShowDialog();
            Visible = true;
        }
        private void buttonVisitData_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FormVisitData(_connectionString).ShowDialog();
            Visible = true;
        }
        private void buttonParentData_Click(object sender, EventArgs e)
        {
            Visible = false;
            new FormParentData(_connectionString).ShowDialog();
            Visible = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
