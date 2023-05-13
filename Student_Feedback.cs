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
    public partial class Student_Feedback : Form
    {
        public Student_Feedback()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Student_Feedback_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
