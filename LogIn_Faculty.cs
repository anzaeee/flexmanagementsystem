using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Striker
{
    public partial class LogIn_Faculty : Form
    {
        public LogIn_Faculty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RedirectFaculty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LandingPage lp = new LandingPage();
            lp.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LogIn_AdminOffice lp = new LogIn_AdminOffice();
            lp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacultyInt_Att obj = new FacultyInt_Att();
            obj.ShowDialog();

            
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DSJ0VD4\\SQLEXPRESS;Initial Catalog=onestop_creation;Integrated Security=True");
            //SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM staff WHERE staff_id='" + textBox1.Text + "' AND password='" + textBox2.Text + "'" + "AND type='Director'", conn);
            ///* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            //DataTable dt = new DataTable(); //this is creating a virtual table  
            //sda.Fill(dt);
            //if (dt.Rows[0][0].ToString() == "1")
            //{
            //    /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
            //    conn.Close();
            //    this.Hide();
            //    new Director().Show();
            //}
            //else
            //    MessageBox.Show("Invalid username or password");
            //conn.Close();
           
        }

        private void LogIn_Faculty_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_f_Click(object sender, EventArgs e)
        {

        }

        private void email_f_Click(object sender, EventArgs e)
        {

        }
    }
}
