namespace Employee_management_system.Gui.UsersGui
{
    partial class AddUserForm
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
            groupBox1 = new GroupBox();
            comboBoxRole = new ComboBox();
            label9 = new Label();
            textBoxPassword = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBoxUserName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxFullName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBoxUserId = new ComboBox();
            checkBoxSecondaryUser = new CheckBox();
            groupBox2 = new GroupBox();
            buttonSave = new Button();
            textBoxAddress = new TextBox();
            label6 = new Label();
            textBoxEmail = new TextBox();
            label10 = new Label();
            textBoxPhoneNumber = new TextBox();
            label12 = new Label();
            groupBox3 = new GroupBox();
            flowLayoutPanelRoles = new FlowLayoutPanel();
            checkBoxAdd = new CheckBox();
            checkBoxDelete = new CheckBox();
            checkBoxEdit = new CheckBox();
            checkBoxExport = new CheckBox();
            checkBoxPrint = new CheckBox();
            checkBoxSearch = new CheckBox();
            checkBoxHomeSearch = new CheckBox();
            checkBoxHome = new CheckBox();
            checkBoxSalary = new CheckBox();
            checkBoxEmployees = new CheckBox();
            checkBoxUsers = new CheckBox();
            checkBoxReport = new CheckBox();
            checkBoxSettings = new CheckBox();
            checkBoxAbout = new CheckBox();
            checkBoxHelp = new CheckBox();
            checkBoxRetirment = new CheckBox();
            checkBoxSystemRecords = new CheckBox();
            label5 = new Label();
            label11 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanelRoles.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxFullName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 488);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الدخول";
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(6, 443);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(349, 31);
            comboBoxRole.TabIndex = 4;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(225, 409);
            label9.Name = "label9";
            label9.Size = new Size(132, 23);
            label9.TabIndex = 4;
            label9.Text = "الصلاحية العامة : ";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 324);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(351, 57);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(246, 283);
            label8.Name = "label8";
            label8.Size = new Size(18, 23);
            label8.TabIndex = 7;
            label8.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(266, 283);
            label7.Name = "label7";
            label7.Size = new Size(91, 23);
            label7.TabIndex = 3;
            label7.Text = "كلمة السر : ";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(13, 195);
            textBoxUserName.Multiline = true;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(350, 54);
            textBoxUserName.TabIndex = 2;
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(231, 149);
            label3.Name = "label3";
            label3.Size = new Size(18, 23);
            label3.TabIndex = 4;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 149);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 2;
            label4.Text = "اسم المستخدم : ";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(12, 72);
            textBoxFullName.Multiline = true;
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(351, 51);
            textBoxFullName.TabIndex = 1;
            textBoxFullName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(243, 34);
            label2.Name = "label2";
            label2.Size = new Size(18, 23);
            label2.TabIndex = 1;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 34);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "الاسم الكامل :";
            // 
            // comboBoxUserId
            // 
            comboBoxUserId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUserId.FormattingEnabled = true;
            comboBoxUserId.Location = new Point(15, 72);
            comboBoxUserId.Name = "comboBoxUserId";
            comboBoxUserId.Size = new Size(349, 31);
            comboBoxUserId.TabIndex = 5;
            // 
            // checkBoxSecondaryUser
            // 
            checkBoxSecondaryUser.AutoSize = true;
            checkBoxSecondaryUser.Location = new Point(207, 34);
            checkBoxSecondaryUser.Name = "checkBoxSecondaryUser";
            checkBoxSecondaryUser.Size = new Size(157, 27);
            checkBoxSecondaryUser.TabIndex = 5;
            checkBoxSecondaryUser.Text = "هل المستخدم ثانوي";
            checkBoxSecondaryUser.UseVisualStyleBackColor = true;
            checkBoxSecondaryUser.CheckedChanged += checkBoxSecondaryUser_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxUserId);
            groupBox2.Controls.Add(buttonSave);
            groupBox2.Controls.Add(checkBoxSecondaryUser);
            groupBox2.Controls.Add(textBoxAddress);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(textBoxPhoneNumber);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(381, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(391, 488);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "معلومات اخرى";
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.Save;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(13, 432);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(351, 50);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "حفظ ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(12, 351);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(351, 57);
            textBoxAddress.TabIndex = 8;
            textBoxAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 325);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 8;
            label6.Text = "السكن : ";
            label6.Click += label6_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(14, 253);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(350, 54);
            textBoxEmail.TabIndex = 7;
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(224, 226);
            label10.Name = "label10";
            label10.Size = new Size(137, 23);
            label10.TabIndex = 7;
            label10.Text = "البريد الالكتروني : ";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(13, 146);
            textBoxPhoneNumber.Multiline = true;
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(351, 51);
            textBoxPhoneNumber.TabIndex = 6;
            textBoxPhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(263, 120);
            label12.Name = "label12";
            label12.Size = new Size(98, 23);
            label12.TabIndex = 6;
            label12.Text = "رقم الهاتف : ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanelRoles);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(1, 507);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(771, 137);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "الصلاحيات";
            // 
            // flowLayoutPanelRoles
            // 
            flowLayoutPanelRoles.Controls.Add(checkBoxAdd);
            flowLayoutPanelRoles.Controls.Add(checkBoxDelete);
            flowLayoutPanelRoles.Controls.Add(checkBoxEdit);
            flowLayoutPanelRoles.Controls.Add(checkBoxExport);
            flowLayoutPanelRoles.Controls.Add(checkBoxPrint);
            flowLayoutPanelRoles.Controls.Add(checkBoxSearch);
            flowLayoutPanelRoles.Controls.Add(checkBoxHomeSearch);
            flowLayoutPanelRoles.Controls.Add(checkBoxHome);
            flowLayoutPanelRoles.Controls.Add(checkBoxSalary);
            flowLayoutPanelRoles.Controls.Add(checkBoxEmployees);
            flowLayoutPanelRoles.Controls.Add(checkBoxUsers);
            flowLayoutPanelRoles.Controls.Add(checkBoxReport);
            flowLayoutPanelRoles.Controls.Add(checkBoxSettings);
            flowLayoutPanelRoles.Controls.Add(checkBoxAbout);
            flowLayoutPanelRoles.Controls.Add(checkBoxHelp);
            flowLayoutPanelRoles.Controls.Add(checkBoxRetirment);
            flowLayoutPanelRoles.Controls.Add(checkBoxSystemRecords);
            flowLayoutPanelRoles.Dock = DockStyle.Fill;
            flowLayoutPanelRoles.ForeColor = Color.Black;
            flowLayoutPanelRoles.Location = new Point(3, 26);
            flowLayoutPanelRoles.Name = "flowLayoutPanelRoles";
            flowLayoutPanelRoles.Size = new Size(765, 108);
            flowLayoutPanelRoles.TabIndex = 0;
            // 
            // checkBoxAdd
            // 
            checkBoxAdd.AutoSize = true;
            checkBoxAdd.Checked = true;
            checkBoxAdd.CheckState = CheckState.Checked;
            checkBoxAdd.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxAdd.Location = new Point(692, 3);
            checkBoxAdd.Name = "checkBoxAdd";
            checkBoxAdd.Padding = new Padding(3);
            checkBoxAdd.Size = new Size(70, 29);
            checkBoxAdd.TabIndex = 10;
            checkBoxAdd.Text = "اضافة";
            checkBoxAdd.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelete
            // 
            checkBoxDelete.AutoSize = true;
            checkBoxDelete.Checked = true;
            checkBoxDelete.CheckState = CheckState.Checked;
            checkBoxDelete.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxDelete.Location = new Point(621, 3);
            checkBoxDelete.Name = "checkBoxDelete";
            checkBoxDelete.Padding = new Padding(3);
            checkBoxDelete.Size = new Size(65, 29);
            checkBoxDelete.TabIndex = 11;
            checkBoxDelete.Text = "حذف";
            checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxEdit
            // 
            checkBoxEdit.AutoSize = true;
            checkBoxEdit.Checked = true;
            checkBoxEdit.CheckState = CheckState.Checked;
            checkBoxEdit.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxEdit.Location = new Point(548, 3);
            checkBoxEdit.Name = "checkBoxEdit";
            checkBoxEdit.Padding = new Padding(3);
            checkBoxEdit.Size = new Size(67, 29);
            checkBoxEdit.TabIndex = 12;
            checkBoxEdit.Text = "تعديل";
            checkBoxEdit.UseVisualStyleBackColor = true;
            // 
            // checkBoxExport
            // 
            checkBoxExport.AutoSize = true;
            checkBoxExport.Checked = true;
            checkBoxExport.CheckState = CheckState.Checked;
            checkBoxExport.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxExport.Location = new Point(461, 3);
            checkBoxExport.Name = "checkBoxExport";
            checkBoxExport.Padding = new Padding(3);
            checkBoxExport.Size = new Size(81, 29);
            checkBoxExport.TabIndex = 13;
            checkBoxExport.Text = "التصدير";
            checkBoxExport.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrint
            // 
            checkBoxPrint.AutoSize = true;
            checkBoxPrint.Checked = true;
            checkBoxPrint.CheckState = CheckState.Checked;
            checkBoxPrint.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxPrint.Location = new Point(385, 3);
            checkBoxPrint.Name = "checkBoxPrint";
            checkBoxPrint.Padding = new Padding(3);
            checkBoxPrint.Size = new Size(70, 29);
            checkBoxPrint.TabIndex = 14;
            checkBoxPrint.Text = "طباعة";
            checkBoxPrint.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearch
            // 
            checkBoxSearch.AutoSize = true;
            checkBoxSearch.Checked = true;
            checkBoxSearch.CheckState = CheckState.Checked;
            checkBoxSearch.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxSearch.Location = new Point(309, 3);
            checkBoxSearch.Name = "checkBoxSearch";
            checkBoxSearch.Padding = new Padding(3);
            checkBoxSearch.Size = new Size(70, 29);
            checkBoxSearch.TabIndex = 15;
            checkBoxSearch.Text = "البحث";
            checkBoxSearch.UseVisualStyleBackColor = true;
            // 
            // checkBoxHomeSearch
            // 
            checkBoxHomeSearch.AutoSize = true;
            checkBoxHomeSearch.Checked = true;
            checkBoxHomeSearch.CheckState = CheckState.Checked;
            checkBoxHomeSearch.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxHomeSearch.Location = new Point(119, 3);
            checkBoxHomeSearch.Name = "checkBoxHomeSearch";
            checkBoxHomeSearch.Padding = new Padding(3);
            checkBoxHomeSearch.Size = new Size(184, 29);
            checkBoxHomeSearch.TabIndex = 16;
            checkBoxHomeSearch.Text = "البحث في الصفحة الرئيسية";
            checkBoxHomeSearch.UseVisualStyleBackColor = true;
            // 
            // checkBoxHome
            // 
            checkBoxHome.AutoSize = true;
            checkBoxHome.Checked = true;
            checkBoxHome.CheckState = CheckState.Checked;
            checkBoxHome.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxHome.Location = new Point(33, 3);
            checkBoxHome.Name = "checkBoxHome";
            checkBoxHome.Padding = new Padding(3);
            checkBoxHome.Size = new Size(80, 29);
            checkBoxHome.TabIndex = 17;
            checkBoxHome.Text = "الرئيسية";
            checkBoxHome.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalary
            // 
            checkBoxSalary.AutoSize = true;
            checkBoxSalary.Checked = true;
            checkBoxSalary.CheckState = CheckState.Checked;
            checkBoxSalary.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxSalary.Location = new Point(658, 38);
            checkBoxSalary.Name = "checkBoxSalary";
            checkBoxSalary.Padding = new Padding(3);
            checkBoxSalary.Size = new Size(104, 29);
            checkBoxSalary.TabIndex = 18;
            checkBoxSalary.Text = "سلم الرواتب";
            checkBoxSalary.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmployees
            // 
            checkBoxEmployees.AutoSize = true;
            checkBoxEmployees.Checked = true;
            checkBoxEmployees.CheckState = CheckState.Checked;
            checkBoxEmployees.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxEmployees.Location = new Point(566, 38);
            checkBoxEmployees.Name = "checkBoxEmployees";
            checkBoxEmployees.Padding = new Padding(3);
            checkBoxEmployees.Size = new Size(86, 29);
            checkBoxEmployees.TabIndex = 19;
            checkBoxEmployees.Text = "الموظفين";
            checkBoxEmployees.UseVisualStyleBackColor = true;
            // 
            // checkBoxUsers
            // 
            checkBoxUsers.AutoSize = true;
            checkBoxUsers.Checked = true;
            checkBoxUsers.CheckState = CheckState.Checked;
            checkBoxUsers.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxUsers.Location = new Point(460, 38);
            checkBoxUsers.Name = "checkBoxUsers";
            checkBoxUsers.Padding = new Padding(3);
            checkBoxUsers.Size = new Size(100, 29);
            checkBoxUsers.TabIndex = 20;
            checkBoxUsers.Text = "المستخدمين";
            checkBoxUsers.UseVisualStyleBackColor = true;
            // 
            // checkBoxReport
            // 
            checkBoxReport.AutoSize = true;
            checkBoxReport.Checked = true;
            checkBoxReport.CheckState = CheckState.Checked;
            checkBoxReport.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxReport.Location = new Point(377, 38);
            checkBoxReport.Name = "checkBoxReport";
            checkBoxReport.Padding = new Padding(3);
            checkBoxReport.Size = new Size(77, 29);
            checkBoxReport.TabIndex = 21;
            checkBoxReport.Text = "التقارير";
            checkBoxReport.UseVisualStyleBackColor = true;
            // 
            // checkBoxSettings
            // 
            checkBoxSettings.AutoSize = true;
            checkBoxSettings.Checked = true;
            checkBoxSettings.CheckState = CheckState.Checked;
            checkBoxSettings.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxSettings.Location = new Point(280, 38);
            checkBoxSettings.Name = "checkBoxSettings";
            checkBoxSettings.Padding = new Padding(3);
            checkBoxSettings.Size = new Size(91, 29);
            checkBoxSettings.TabIndex = 22;
            checkBoxSettings.Text = "الاعدادات";
            checkBoxSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxAbout
            // 
            checkBoxAbout.AutoSize = true;
            checkBoxAbout.Checked = true;
            checkBoxAbout.CheckState = CheckState.Checked;
            checkBoxAbout.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxAbout.Location = new Point(175, 38);
            checkBoxAbout.Name = "checkBoxAbout";
            checkBoxAbout.Padding = new Padding(3);
            checkBoxAbout.Size = new Size(99, 29);
            checkBoxAbout.TabIndex = 23;
            checkBoxAbout.Text = "حول النظام";
            checkBoxAbout.UseVisualStyleBackColor = true;
            // 
            // checkBoxHelp
            // 
            checkBoxHelp.AutoSize = true;
            checkBoxHelp.Checked = true;
            checkBoxHelp.CheckState = CheckState.Checked;
            checkBoxHelp.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxHelp.Location = new Point(84, 38);
            checkBoxHelp.Name = "checkBoxHelp";
            checkBoxHelp.Padding = new Padding(3);
            checkBoxHelp.Size = new Size(85, 29);
            checkBoxHelp.TabIndex = 24;
            checkBoxHelp.Text = "المساعدة";
            checkBoxHelp.UseVisualStyleBackColor = true;
            // 
            // checkBoxRetirment
            // 
            checkBoxRetirment.AutoSize = true;
            checkBoxRetirment.Checked = true;
            checkBoxRetirment.CheckState = CheckState.Checked;
            checkBoxRetirment.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxRetirment.Location = new Point(670, 73);
            checkBoxRetirment.Name = "checkBoxRetirment";
            checkBoxRetirment.Padding = new Padding(3);
            checkBoxRetirment.Size = new Size(92, 29);
            checkBoxRetirment.TabIndex = 25;
            checkBoxRetirment.Text = "المتقاعدين";
            checkBoxRetirment.UseVisualStyleBackColor = true;
            // 
            // checkBoxSystemRecords
            // 
            checkBoxSystemRecords.AutoSize = true;
            checkBoxSystemRecords.Checked = true;
            checkBoxSystemRecords.CheckState = CheckState.Checked;
            checkBoxSystemRecords.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxSystemRecords.Location = new Point(557, 73);
            checkBoxSystemRecords.Name = "checkBoxSystemRecords";
            checkBoxSystemRecords.Padding = new Padding(3);
            checkBoxSystemRecords.Size = new Size(107, 29);
            checkBoxSystemRecords.TabIndex = 26;
            checkBoxSystemRecords.Text = "سجل الحركة";
            checkBoxSystemRecords.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(66, 35);
            label5.Name = "label5";
            label5.Size = new Size(116, 19);
            label5.TabIndex = 8;
            label5.Text = " 3 احرف اقل شيء";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.LightGray;
            label11.Location = new Point(66, 153);
            label11.Name = "label11";
            label11.Size = new Size(116, 19);
            label11.TabIndex = 9;
            label11.Text = " 3 احرف اقل شيء";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.LightGray;
            label13.Location = new Point(66, 283);
            label13.Name = "label13";
            label13.Size = new Size(116, 19);
            label13.TabIndex = 10;
            label13.Text = " 3 احرف اقل شيء";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 644);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة / تعديل مستخدم";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            flowLayoutPanelRoles.ResumeLayout(false);
            flowLayoutPanelRoles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBoxFullName;
        private TextBox textBoxUserName;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxUserId;
        private CheckBox checkBoxSecondaryUser;
        private TextBox textBoxPassword;
        private Label label8;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox textBoxAddress;
        private Label label6;
        private TextBox textBoxEmail;
        private Label label10;
        private TextBox textBoxPhoneNumber;
        private Label label12;
        private GroupBox groupBox3;
        private Button buttonSave;
        private FlowLayoutPanel flowLayoutPanelRoles;
        private CheckBox checkBoxAdd;
        private CheckBox checkBoxDelete;
        private CheckBox checkBoxEdit;
        private CheckBox checkBoxExport;
        private CheckBox checkBoxPrint;
        private CheckBox checkBoxSearch;
        private CheckBox checkBoxHomeSearch;
        private CheckBox checkBoxHome;
        private CheckBox checkBoxSalary;
        private CheckBox checkBoxEmployees;
        private Label label9;
        private ComboBox comboBoxRole;
        private CheckBox checkBoxUsers;
        private CheckBox checkBoxReport;
        private CheckBox checkBoxSettings;
        private CheckBox checkBoxAbout;
        private CheckBox checkBoxHelp;
        private CheckBox checkBoxRetirment;
        private CheckBox checkBoxSystemRecords;
        private Label label5;
        private Label label13;
        private Label label11;
    }
}