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
    public partial class OfficeInt_OC : Form
    {
        public OfficeInt_OC()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("You have been logged out successfully."); this.Hide();
            LogIn_Faculty obj = new LogIn_Faculty();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         // //  this.Hide();
         //   OfficeInt_OC obj = new OfficeInt_OC();
          //  obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfficeInt_SS obj = new OfficeInt_SS();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfficeInt_CA obj = new OfficeInt_CA();
            obj.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            OfficeInt_Allocation obj = new OfficeInt_Allocation();
            obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfficeInt_SS obj = new OfficeInt_SS();
            obj.ShowDialog();
        }
    }
}
