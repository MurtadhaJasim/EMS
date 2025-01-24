﻿using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Color = System.Drawing.Color;
using Font = System.Drawing.Font;

namespace Employee_management_system.Gui.UsersGui
{
    partial class LoginForm
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
            textBoxPassword = new TextBox();
            label6 = new Label();
            textBoxUserName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            pictureBoxLoding = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonlogin = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoding).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(31, 420);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(385, 30);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(289, 372);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 0;
            label6.Text = "*";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(31, 305);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(385, 30);
            textBoxUserName.TabIndex = 0;
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(250, 252);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 0;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(312, 380);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 0;
            label5.Text = "كلمة السر:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(272, 258);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 0;
            label3.Text = "اسم المستخدم:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBoxLoding);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonlogin);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUserName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 605);
            panel1.TabIndex = 1;
            // 
            // pictureBoxLoding
            // 
            pictureBoxLoding.Image = Properties.Resources.Loading;
            pictureBoxLoding.Location = new Point(31, 493);
            pictureBoxLoding.Name = "pictureBoxLoding";
            pictureBoxLoding.Size = new Size(148, 90);
            pictureBoxLoding.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLoding.TabIndex = 2;
            pictureBoxLoding.TabStop = false;
            pictureBoxLoding.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logingif;
            pictureBox2.Location = new Point(96, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(282, 223);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // buttonlogin
            // 
            buttonlogin.BackgroundImage = Properties.Resources.Login;
            buttonlogin.ForeColor = Color.Black;
            buttonlogin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonlogin.Location = new Point(210, 505);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(206, 60);
            buttonlogin.TabIndex = 2;
            buttonlogin.Text = "تسجيل الدخول";
            buttonlogin.UseVisualStyleBackColor = true;
            buttonlogin.Click += buttonSave_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(453, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(419, 605);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.loginuser;
            pictureBox1.Location = new Point(40, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 252);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(71, 90);
            label2.Name = "label2";
            label2.Size = new Size(209, 29);
            label2.TabIndex = 0;
            label2.Text = "سجل دخولك لاكمال عملك";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(327, 46);
            label1.TabIndex = 0;
            label1.Text = "مرحبا بك مرة اخرى !";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 605);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F);
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول";
            FormClosed += LoginForm_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLoding).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxPassword;
        private Label label6;
        private TextBox textBoxUserName;
        private Label label4;
        private Label label5;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button buttonlogin;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxLoding;
    }
}