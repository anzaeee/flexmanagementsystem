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
    public partial class Student_Interface : Form
    {
        public Student_Interface()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LandingPage().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Student_Interface_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out successfully."); this.Hide();
            LandingPage obj = new LandingPage();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Interface obj = new Student_Interface();
            obj.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Feedback obj = new Student_Feedback();
            obj.ShowDialog();
        }
    }
}
