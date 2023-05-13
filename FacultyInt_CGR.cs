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
    public partial class FacultyInt_CGR : Form
    {
        public FacultyInt_CGR()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyInt_SFR obj = new FacultyInt_SFR();
            obj.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out successfully."); this.Hide();
            LogIn_Faculty obj = new LogIn_Faculty();
            obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyInt_GR obj = new FacultyInt_GR();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyInterface obj = new FacultyInterface();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyInt_Att obj = new FacultyInt_Att();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyInt_ER obj = new FacultyInt_ER();
            obj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
