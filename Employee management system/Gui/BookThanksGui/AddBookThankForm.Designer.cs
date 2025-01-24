namespace Employee_management_system.Gui.BookThanksGui
{
    partial class AddBookThankForm
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
            richTextBoxNote = new RichTextBox();
            dateTimePickerdate = new DateTimePicker();
            numericUpDownEffect = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBoxRef = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonSave = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEffect).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBoxNote);
            groupBox1.Controls.Add(dateTimePickerdate);
            groupBox1.Controls.Add(numericUpDownEffect);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBoxRef);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 586);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات كتاب الشكر";
            // 
            // richTextBoxNote
            // 
            richTextBoxNote.Location = new Point(13, 445);
            richTextBoxNote.Name = "richTextBoxNote";
            richTextBoxNote.Size = new Size(344, 135);
            richTextBoxNote.TabIndex = 13;
            richTextBoxNote.Text = "";
            // 
            // dateTimePickerdate
            // 
            dateTimePickerdate.Format = DateTimePickerFormat.Short;
            dateTimePickerdate.Location = new Point(14, 338);
            dateTimePickerdate.Name = "dateTimePickerdate";
            dateTimePickerdate.Size = new Size(340, 30);
            dateTimePickerdate.TabIndex = 11;
            // 
            // numericUpDownEffect
            // 
            numericUpDownEffect.Location = new Point(15, 78);
            numericUpDownEffect.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownEffect.Name = "numericUpDownEffect";
            numericUpDownEffect.Size = new Size(339, 30);
            numericUpDownEffect.TabIndex = 1;
            numericUpDownEffect.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(274, 407);
            label9.Name = "label9";
            label9.Size = new Size(83, 23);
            label9.TabIndex = 4;
            label9.Text = "التفاصيل : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(274, 279);
            label8.Name = "label8";
            label8.Size = new Size(18, 23);
            label8.TabIndex = 7;
            label8.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(282, 279);
            label7.Name = "label7";
            label7.Size = new Size(72, 23);
            label7.TabIndex = 3;
            label7.Text = "التاريخ : ";
            // 
            // textBoxRef
            // 
            textBoxRef.Location = new Point(13, 195);
            textBoxRef.Multiline = true;
            textBoxRef.Name = "textBoxRef";
            textBoxRef.Size = new Size(341, 54);
            textBoxRef.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(274, 148);
            label3.Name = "label3";
            label3.Size = new Size(18, 23);
            label3.TabIndex = 4;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 148);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 2;
            label4.Text = "العدد : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(274, 39);
            label2.Name = "label2";
            label2.Size = new Size(18, 23);
            label2.TabIndex = 1;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 39);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 0;
            label1.Text = "التأثير : ";
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.Save;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(18, 604);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(351, 50);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "حفظ ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddBookThankForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 666);
            Controls.Add(buttonSave);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddBookThankForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة كتاب شكر";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEffect).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numericUpDownEffect;
        private Label label2;
        private Label label1;
        private TextBox textBoxSalary;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label7;
        private TextBox textBoxRef;
        private Button buttonSave;
        private Label label9;
        private Label labelSalaryCurrency;
        private NumericUpDown numericUpDownDegree;
        private DateTimePicker dateTimePickerdate;
        private RichTextBox richTextBoxNote;
    }
}