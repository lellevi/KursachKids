using KursachProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KursachProject
{
    public partial class DropdownEditForm : Form
    {
        public int SelectedID { get; private set; }
        public string SelectedValue { get; private set; } 

        public DropdownEditForm(string title, List<ComboBoxItem> items)
        {
            Name = title;
            InitializeComponent();
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Name"; 
            comboBox1.ValueMember = "ID";    

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                SelectedID = (int)comboBox1.SelectedValue; 
                SelectedValue = ((ComboBoxItem)comboBox1.SelectedItem).Name; 
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка.");
            }
        }
    }
}
