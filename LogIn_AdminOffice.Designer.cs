namespace Striker
{
    partial class LogIn_AdminOffice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.RedirectToStudent = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pass_f = new System.Windows.Forms.Label();
            this.email_f = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Location = new System.Drawing.Point(190, 463);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel1.Size = new System.Drawing.Size(72, 16);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click Here.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Are you faculty?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RedirectToStudent
            // 
            this.RedirectToStudent.AutoSize = true;
            this.RedirectToStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RedirectToStudent.Location = new System.Drawing.Point(190, 436);
            this.RedirectToStudent.Name = "RedirectToStudent";
            this.RedirectToStudent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RedirectToStudent.Size = new System.Drawing.Size(72, 16);
            this.RedirectToStudent.TabIndex = 21;
            this.RedirectToStudent.TabStop = true;
            this.RedirectToStudent.Text = "Click Here.";
            this.RedirectToStudent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RedirectToStudent_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Are you a student?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(67, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Academic Office";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Welcome to FLEX Management";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Log In";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 280);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 22);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 22);
            this.textBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(70, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pass_f
            // 
            this.pass_f.AutoSize = true;
            this.pass_f.Location = new System.Drawing.Point(67, 249);
            this.pass_f.Name = "pass_f";
            this.pass_f.Size = new System.Drawing.Size(70, 16);
            this.pass_f.TabIndex = 13;
            this.pass_f.Text = "Password:";
            // 
            // email_f
            // 
            this.email_f.AutoSize = true;
            this.email_f.Location = new System.Drawing.Point(67, 166);
            this.email_f.Name = "email_f";
            this.email_f.Size = new System.Drawing.Size(44, 16);
            this.email_f.TabIndex = 12;
            this.email_f.Text = "Email:";
            // 
            // LogIn_AdminOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 565);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RedirectToStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pass_f);
            this.Controls.Add(this.email_f);
            this.Name = "LogIn_AdminOffice";
            this.Text = "LogIn_AdminOffice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel RedirectToStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label pass_f;
        private System.Windows.Forms.Label email_f;
    }
}