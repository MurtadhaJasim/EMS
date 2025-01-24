namespace Employee_management_system.Gui.SalaryRateGui
{
    partial class AddSalaryRateForm
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
            numericUpDownPromotion = new NumericUpDown();
            numericUpDownDegree = new NumericUpDown();
            labelBonusCurrency = new Label();
            labelSalaryCurrency = new Label();
            label9 = new Label();
            textBoxBonusYear = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBoxSalary = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonSave = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPromotion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDegree).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownPromotion);
            groupBox1.Controls.Add(numericUpDownDegree);
            groupBox1.Controls.Add(labelBonusCurrency);
            groupBox1.Controls.Add(labelSalaryCurrency);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxBonusYear);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBoxSalary);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 511);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الدخول";
            // 
            // numericUpDownPromotion
            // 
            numericUpDownPromotion.Location = new Point(12, 457);
            numericUpDownPromotion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPromotion.Name = "numericUpDownPromotion";
            numericUpDownPromotion.Size = new Size(342, 30);
            numericUpDownPromotion.TabIndex = 4;
            numericUpDownPromotion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownDegree
            // 
            numericUpDownDegree.Location = new Point(15, 78);
            numericUpDownDegree.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDegree.Name = "numericUpDownDegree";
            numericUpDownDegree.Size = new Size(342, 30);
            numericUpDownDegree.TabIndex = 1;
            numericUpDownDegree.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelBonusCurrency
            // 
            labelBonusCurrency.AutoSize = true;
            labelBonusCurrency.BackColor = SystemColors.Control;
            labelBonusCurrency.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBonusCurrency.ForeColor = Color.DarkGray;
            labelBonusCurrency.Location = new Point(66, 283);
            labelBonusCurrency.Name = "labelBonusCurrency";
            labelBonusCurrency.Size = new Size(29, 19);
            labelBonusCurrency.TabIndex = 10;
            labelBonusCurrency.Text = "د.ع";
            // 
            // labelSalaryCurrency
            // 
            labelSalaryCurrency.AutoSize = true;
            labelSalaryCurrency.BackColor = SystemColors.Control;
            labelSalaryCurrency.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSalaryCurrency.ForeColor = Color.DarkGray;
            labelSalaryCurrency.Location = new Point(66, 153);
            labelSalaryCurrency.Name = "labelSalaryCurrency";
            labelSalaryCurrency.Size = new Size(29, 19);
            labelSalaryCurrency.TabIndex = 9;
            labelSalaryCurrency.Text = "د.ع";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(207, 418);
            label9.Name = "label9";
            label9.Size = new Size(150, 23);
            label9.TabIndex = 4;
            label9.Text = "عدد سنوات الترفيع : ";
            // 
            // textBoxBonusYear
            // 
            textBoxBonusYear.Location = new Point(12, 324);
            textBoxBonusYear.Multiline = true;
            textBoxBonusYear.Name = "textBoxBonusYear";
            textBoxBonusYear.Size = new Size(351, 57);
            textBoxBonusYear.TabIndex = 3;
            textBoxBonusYear.Text = "0";
            textBoxBonusYear.TextChanged += textBoxBonusYear_TextChanged;
            textBoxBonusYear.MouseLeave += textBoxBonusYear_MouseLeave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(231, 279);
            label8.Name = "label8";
            label8.Size = new Size(18, 23);
            label8.TabIndex = 7;
            label8.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(234, 283);
            label7.Name = "label7";
            label7.Size = new Size(123, 23);
            label7.TabIndex = 3;
            label7.Text = "العلاوة السنوية : ";
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(13, 195);
            textBoxSalary.Multiline = true;
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(350, 54);
            textBoxSalary.TabIndex = 2;
            textBoxSalary.Text = "0";
            textBoxSalary.MouseLeave += textBoxSalary_MouseLeave;
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
            label4.Location = new Point(236, 149);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 2;
            label4.Text = "الراتب الاسمي : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(216, 31);
            label2.Name = "label2";
            label2.Size = new Size(18, 23);
            label2.TabIndex = 1;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 40);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 0;
            label1.Text = "   الدرجة الوظيفية : ";
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.Save;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(18, 545);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(351, 50);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "حفظ ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddSalaryRateForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 611);
            Controls.Add(buttonSave);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddSalaryRateForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة / تعديل مستخدم";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPromotion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDegree).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBoxSalary;
        private Label label3;
        private Label label4;
        private TextBox textBoxBonusYear;
        private Label label8;
        private Label label7;
        private Button buttonSave;
        private Label label9;
        private Label labelBonusCurrency;
        private Label labelSalaryCurrency;
        private NumericUpDown numericUpDownPromotion;
        private NumericUpDown numericUpDownDegree;
    }
}