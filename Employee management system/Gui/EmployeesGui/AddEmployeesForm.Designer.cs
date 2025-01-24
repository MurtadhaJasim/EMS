

namespace Employee_management_system.Gui.EmployeesGui
{
    partial class AddEmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeesForm));
            groupBox1 = new GroupBox();
            label13 = new Label();
            label15 = new Label();
            label12 = new Label();
            dateTimePickerLastPromotion = new DateTimePicker();
            comboBoxEmpState = new ComboBox();
            comboBoxJobTitle = new ComboBox();
            label14 = new Label();
            label11 = new Label();
            label2 = new Label();
            textBoxFullName = new TextBox();
            label1 = new Label();
            buttonSave = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox4 = new GroupBox();
            richTextBoxNote = new RichTextBox();
            groupBox3 = new GroupBox();
            dateTimePickerNextDate = new DateTimePicker();
            label3 = new Label();
            textBoxNextSalary = new TextBox();
            numericUpDownNextStage = new NumericUpDown();
            label4 = new Label();
            numericUpDownNextDegree = new NumericUpDown();
            labelEmployeeCurrency = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            dateTimePickerCurrentDate = new DateTimePicker();
            label8 = new Label();
            textBoxCurrentSalary = new TextBox();
            numericUpDownCurrentStage = new NumericUpDown();
            label7 = new Label();
            numericUpDownCurrentDegree = new NumericUpDown();
            labelBonusCurrency = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            buttonUpgrade = new Button();
            buttonAutoCal = new Button();
            buttonNew = new Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNextStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNextDegree).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCurrentStage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCurrentDegree).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dateTimePickerLastPromotion);
            groupBox1.Controls.Add(comboBoxEmpState);
            groupBox1.Controls.Add(comboBoxJobTitle);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxFullName);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(-6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(846, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الاساسية";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Right;
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(693, 38);
            label13.Name = "label13";
            label13.Size = new Size(18, 23);
            label13.TabIndex = 15;
            label13.Text = "*";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Right;
            label15.AutoSize = true;
            label15.ForeColor = Color.Red;
            label15.Location = new Point(321, 46);
            label15.Name = "label15";
            label15.Size = new Size(18, 23);
            label15.TabIndex = 14;
            label15.Text = "*";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Right;
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(424, 46);
            label12.Name = "label12";
            label12.Size = new Size(18, 23);
            label12.TabIndex = 14;
            label12.Text = "*";
            // 
            // dateTimePickerLastPromotion
            // 
            dateTimePickerLastPromotion.Anchor = AnchorStyles.Left;
            dateTimePickerLastPromotion.Format = DateTimePickerFormat.Short;
            dateTimePickerLastPromotion.Location = new Point(16, 73);
            dateTimePickerLastPromotion.Name = "dateTimePickerLastPromotion";
            dateTimePickerLastPromotion.RightToLeftLayout = true;
            dateTimePickerLastPromotion.Size = new Size(196, 30);
            dateTimePickerLastPromotion.TabIndex = 3;
            // 
            // comboBoxEmpState
            // 
            comboBoxEmpState.Anchor = AnchorStyles.Right;
            comboBoxEmpState.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxEmpState.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxEmpState.FormattingEnabled = true;
            comboBoxEmpState.Items.AddRange(new object[] { "علاوة", "ترفيع", "قيد علاوة", "قيد ترفيع", "متوقف", "تحت المعالجة" });
            comboBoxEmpState.Location = new Point(271, 72);
            comboBoxEmpState.Name = "comboBoxEmpState";
            comboBoxEmpState.Size = new Size(124, 31);
            comboBoxEmpState.TabIndex = 2;
            // 
            // comboBoxJobTitle
            // 
            comboBoxJobTitle.Anchor = AnchorStyles.Right;
            comboBoxJobTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxJobTitle.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxJobTitle.FormattingEnabled = true;
            comboBoxJobTitle.Location = new Point(438, 72);
            comboBoxJobTitle.Name = "comboBoxJobTitle";
            comboBoxJobTitle.Size = new Size(124, 31);
            comboBoxJobTitle.TabIndex = 2;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(331, 46);
            label14.Name = "label14";
            label14.Size = new Size(64, 23);
            label14.TabIndex = 5;
            label14.Text = "الحالة : ";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(86, 46);
            label11.Name = "label11";
            label11.Size = new Size(135, 23);
            label11.TabIndex = 13;
            label11.Text = "تاريخ اخر ترفيع : ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(438, 46);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 5;
            label2.Text = "العنوان الوظيفي :";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Anchor = AnchorStyles.Right;
            textBoxFullName.Location = new Point(607, 64);
            textBoxFullName.Multiline = true;
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(208, 39);
            textBoxFullName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(717, 38);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 3;
            label1.Text = "الاسم الكامل :";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Right;
            buttonSave.Image = Properties.Resources.Save;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(684, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(159, 60);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "حفظ ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(857, 605);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(849, 569);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "العلاوة والترفيع   ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(richTextBoxNote);
            groupBox4.ForeColor = SystemColors.ControlText;
            groupBox4.Location = new Point(6, 376);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(834, 122);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "الملاحظات";
            // 
            // richTextBoxNote
            // 
            richTextBoxNote.Dock = DockStyle.Fill;
            richTextBoxNote.Location = new Point(3, 26);
            richTextBoxNote.Name = "richTextBoxNote";
            richTextBoxNote.Size = new Size(828, 93);
            richTextBoxNote.TabIndex = 12;
            richTextBoxNote.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dateTimePickerNextDate);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBoxNextSalary);
            groupBox3.Controls.Add(numericUpDownNextStage);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(numericUpDownNextDegree);
            groupBox3.Controls.Add(labelEmployeeCurrency);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.ForeColor = SystemColors.ControlText;
            groupBox3.Location = new Point(6, 250);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(834, 120);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "العلاوة القادمة";
            // 
            // dateTimePickerNextDate
            // 
            dateTimePickerNextDate.Anchor = AnchorStyles.Left;
            dateTimePickerNextDate.Format = DateTimePickerFormat.Short;
            dateTimePickerNextDate.Location = new Point(12, 65);
            dateTimePickerNextDate.Name = "dateTimePickerNextDate";
            dateTimePickerNextDate.RightToLeftLayout = true;
            dateTimePickerNextDate.Size = new Size(246, 30);
            dateTimePickerNextDate.TabIndex = 11;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(178, 39);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 13;
            label3.Text = "التاريخ : ";
            // 
            // textBoxNextSalary
            // 
            textBoxNextSalary.Anchor = AnchorStyles.Right;
            textBoxNextSalary.Location = new Point(305, 65);
            textBoxNextSalary.Multiline = true;
            textBoxNextSalary.Name = "textBoxNextSalary";
            textBoxNextSalary.Size = new Size(204, 30);
            textBoxNextSalary.TabIndex = 10;
            textBoxNextSalary.Text = "0";
            textBoxNextSalary.MouseLeave += textBoxNextSalary_MouseLeave;
            // 
            // numericUpDownNextStage
            // 
            numericUpDownNextStage.Anchor = AnchorStyles.Right;
            numericUpDownNextStage.Location = new Point(586, 64);
            numericUpDownNextStage.Name = "numericUpDownNextStage";
            numericUpDownNextStage.Size = new Size(85, 30);
            numericUpDownNextStage.TabIndex = 9;
            numericUpDownNextStage.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownNextStage.ValueChanged += numericUpDownNextStage_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(599, 39);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 10;
            label4.Text = "المرحلة : ";
            // 
            // numericUpDownNextDegree
            // 
            numericUpDownNextDegree.Anchor = AnchorStyles.Right;
            numericUpDownNextDegree.Location = new Point(736, 64);
            numericUpDownNextDegree.Name = "numericUpDownNextDegree";
            numericUpDownNextDegree.Size = new Size(82, 30);
            numericUpDownNextDegree.TabIndex = 8;
            numericUpDownNextDegree.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownNextDegree.ValueChanged += numericUpDownNextDegree_ValueChanged;
            // 
            // labelEmployeeCurrency
            // 
            labelEmployeeCurrency.Anchor = AnchorStyles.Right;
            labelEmployeeCurrency.AutoSize = true;
            labelEmployeeCurrency.ForeColor = Color.DarkGray;
            labelEmployeeCurrency.Location = new Point(293, 39);
            labelEmployeeCurrency.Name = "labelEmployeeCurrency";
            labelEmployeeCurrency.Size = new Size(34, 23);
            labelEmployeeCurrency.TabIndex = 8;
            labelEmployeeCurrency.Text = "د.ع";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(370, 39);
            label9.Name = "label9";
            label9.Size = new Size(121, 23);
            label9.TabIndex = 8;
            label9.Text = "الراتب الاسمي : ";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(749, 39);
            label10.Name = "label10";
            label10.Size = new Size(72, 23);
            label10.TabIndex = 7;
            label10.Text = "الدرجة : ";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dateTimePickerCurrentDate);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBoxCurrentSalary);
            groupBox2.Controls.Add(numericUpDownCurrentStage);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(numericUpDownCurrentDegree);
            groupBox2.Controls.Add(labelBonusCurrency);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(3, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(837, 120);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "العلاوة الحالية";
            // 
            // dateTimePickerCurrentDate
            // 
            dateTimePickerCurrentDate.Anchor = AnchorStyles.Left;
            dateTimePickerCurrentDate.Format = DateTimePickerFormat.Short;
            dateTimePickerCurrentDate.Location = new Point(7, 65);
            dateTimePickerCurrentDate.Name = "dateTimePickerCurrentDate";
            dateTimePickerCurrentDate.RightToLeftLayout = true;
            dateTimePickerCurrentDate.Size = new Size(253, 30);
            dateTimePickerCurrentDate.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(194, 39);
            label8.Name = "label8";
            label8.Size = new Size(72, 23);
            label8.TabIndex = 13;
            label8.Text = "التاريخ : ";
            // 
            // textBoxCurrentSalary
            // 
            textBoxCurrentSalary.Anchor = AnchorStyles.Right;
            textBoxCurrentSalary.Location = new Point(308, 65);
            textBoxCurrentSalary.Multiline = true;
            textBoxCurrentSalary.Name = "textBoxCurrentSalary";
            textBoxCurrentSalary.Size = new Size(204, 30);
            textBoxCurrentSalary.TabIndex = 6;
            textBoxCurrentSalary.Text = "0";
            textBoxCurrentSalary.MouseLeave += textBoxCurrentSalary_MouseLeave;
            // 
            // numericUpDownCurrentStage
            // 
            numericUpDownCurrentStage.Anchor = AnchorStyles.Right;
            numericUpDownCurrentStage.Location = new Point(589, 65);
            numericUpDownCurrentStage.Name = "numericUpDownCurrentStage";
            numericUpDownCurrentStage.Size = new Size(85, 30);
            numericUpDownCurrentStage.TabIndex = 5;
            numericUpDownCurrentStage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCurrentStage.ValueChanged += numericUpDownCurrentStage_ValueChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(615, 39);
            label7.Name = "label7";
            label7.Size = new Size(77, 23);
            label7.TabIndex = 10;
            label7.Text = "المرحلة : ";
            // 
            // numericUpDownCurrentDegree
            // 
            numericUpDownCurrentDegree.Anchor = AnchorStyles.Right;
            numericUpDownCurrentDegree.Location = new Point(739, 65);
            numericUpDownCurrentDegree.Name = "numericUpDownCurrentDegree";
            numericUpDownCurrentDegree.Size = new Size(85, 30);
            numericUpDownCurrentDegree.TabIndex = 4;
            numericUpDownCurrentDegree.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCurrentDegree.ValueChanged += numericUpDownCurrentDegree_ValueChanged;
            // 
            // labelBonusCurrency
            // 
            labelBonusCurrency.Anchor = AnchorStyles.Right;
            labelBonusCurrency.AutoSize = true;
            labelBonusCurrency.ForeColor = Color.DarkGray;
            labelBonusCurrency.Location = new Point(312, 38);
            labelBonusCurrency.Name = "labelBonusCurrency";
            labelBonusCurrency.Size = new Size(34, 23);
            labelBonusCurrency.TabIndex = 8;
            labelBonusCurrency.Text = "د.ع";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(386, 39);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 8;
            label6.Text = "الراتب الاسمي : ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(753, 39);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 7;
            label5.Text = "الدرجة : ";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonUpgrade);
            panel1.Controls.Add(buttonAutoCal);
            panel1.Controls.Add(buttonNew);
            panel1.Controls.Add(buttonSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 504);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 62);
            panel1.TabIndex = 6;
            // 
            // buttonUpgrade
            // 
            buttonUpgrade.Anchor = AnchorStyles.Left;
            buttonUpgrade.Image = Properties.Resources.Save;
            buttonUpgrade.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUpgrade.Location = new Point(3, 0);
            buttonUpgrade.Name = "buttonUpgrade";
            buttonUpgrade.Size = new Size(209, 60);
            buttonUpgrade.TabIndex = 16;
            buttonUpgrade.Text = "  اجراء العلاوة والترفيع";
            buttonUpgrade.UseVisualStyleBackColor = true;
            buttonUpgrade.Click += buttonUpgrade_Click;
            // 
            // buttonAutoCal
            // 
            buttonAutoCal.Anchor = AnchorStyles.Right;
            buttonAutoCal.Image = Properties.Resources.Save;
            buttonAutoCal.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAutoCal.Location = new Point(348, 0);
            buttonAutoCal.Name = "buttonAutoCal";
            buttonAutoCal.Size = new Size(159, 60);
            buttonAutoCal.TabIndex = 15;
            buttonAutoCal.Text = "  الحساب التلقائي ";
            buttonAutoCal.UseVisualStyleBackColor = true;
            buttonAutoCal.Click += buttonAutoCal_Click;
            // 
            // buttonNew
            // 
            buttonNew.Anchor = AnchorStyles.Right;
            buttonNew.Image = Properties.Resources.Save;
            buttonNew.ImageAlign = ContentAlignment.MiddleLeft;
            buttonNew.Location = new Point(520, 0);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(159, 60);
            buttonNew.TabIndex = 14;
            buttonNew.Text = "جديد ";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(849, 569);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "التشكرات   ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(849, 569);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "الاجازات   ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 32);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(849, 569);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "الغيابات   ";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 32);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(849, 569);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "سجل العلاوات   ";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // AddEmployeesForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 605);
            Controls.Add(tabControl1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddEmployeesForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة / تعديل موظف";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNextStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNextDegree).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCurrentStage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCurrentDegree).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }







        #endregion

        private GroupBox groupBox1;
        private Button buttonSave;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Panel panel1;
        private Label label2;
        private TextBox textBoxFullName;
        private Label label1;
        private ComboBox comboBoxJobTitle;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDownCurrentDegree;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDownCurrentStage;
        private Label label7;
        private Label label8;
        private TextBox textBoxCurrentSalary;
        private DateTimePicker dateTimePickerCurrentDate;
        private DateTimePicker dateTimePickerLastPromotion;
        private Label label11;
        private GroupBox groupBox3;
        private DateTimePicker dateTimePickerNextDate;
        private Label label3;
        private TextBox textBoxNextSalary;
        private NumericUpDown numericUpDownNextStage;
        private Label label4;
        private NumericUpDown numericUpDownNextDegree;
        private Label label9;
        private Label label10;
        private GroupBox groupBox4;
        private RichTextBox richTextBoxNote;
        private Label labelBonusCurrency;
        private Label labelEmployeeCurrency;
        private Label label13;
        private Label label12;
        private Label label15;
        private ComboBox comboBoxEmpState;
        private Label label14;
        private Button buttonAutoCal;
        private Button buttonNew;
        private Button buttonUpgrade;
    }
}