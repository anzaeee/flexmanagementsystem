using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Striker
{
    public partial class FacultyInt_Marks : Form
    {
        public FacultyInt_Marks()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out successfully."); this.Hide();
            LogIn_Faculty obj = new LogIn_Faculty();
            obj.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FacultyInt_ER obj = new FacultyInt_ER();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyInt_ER obj = new FacultyInt_ER();
            obj.ShowDialog()
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
