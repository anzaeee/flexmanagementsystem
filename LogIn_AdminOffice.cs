﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Striker
{
    public partial class LogIn_AdminOffice : Form
    {
        public LogIn_AdminOffice()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RedirectToStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LandingPage obj = new LandingPage();
            obj.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LogIn_Faculty obj = new LogIn_Faculty();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfficeInt_OC obj = new OfficeInt_OC();
            obj.ShowDialog();

            //    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DSJ0VD4\\SQLEXPRESS;Initial Catalog=onestop_creation;Integrated Security=True");
            //    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM staff WHERE staff_id='" + textBox1.Text + "' AND password='" + textBox2.Text + "'" + "AND type='Director'", conn);
            //    /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            //    DataTable dt = new DataTable(); //this is creating a virtual table  
            //    sda.Fill(dt);
            //    if (dt.Rows[0][0].ToString() == "1")
            //    {
            //        /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
            //        conn.Close();
            //        this.Hide();
            //        new Director().Show();
            //    }
            //    else
            //        MessageBox.Show("Invalid username or password");
            //    conn.Close();
            //}
        }
    }
}
