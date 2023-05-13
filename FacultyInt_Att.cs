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
    public partial class FacultyInt_Att : Form
    {
        public FacultyInt_Att()
        {
            InitializeComponent();
        }

        private void FacultyInt_Att_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out successfully.");
            this.Hide();
            LogIn_Faculty obj = new LogIn_Faculty();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyInterface obj = new FacultyInterface();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyInt_ER obj = new FacultyInt_ER();
            obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyInt_GR obj = new FacultyInt_GR();
            obj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyInt_CGR obj = new FacultyInt_CGR();
            obj.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyInt_SFR obj = new FacultyInt_SFR();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FacultyInt_A obj = new FacultyInt_A();
            obj.ShowDialog();
        }
    }
}
