namespace Employee_management_system.Gui.ToastGui
{
    partial class ToastForm
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            labelTitle = new Label();
            labelDescription = new Label();
            timerToast = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.Notification;
            pictureBox1.Location = new Point(258, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.RightToLeft = RightToLeft.Yes;
            labelTitle.Size = new Size(258, 34);
            labelTitle.TabIndex = 1;
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            labelTitle.Click += labelTitle_Click;
            // 
            // labelDescription
            // 
            labelDescription.Dock = DockStyle.Top;
            labelDescription.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.Location = new Point(0, 34);
            labelDescription.Name = "labelDescription";
            labelDescription.RightToLeft = RightToLeft.Yes;
            labelDescription.Size = new Size(258, 34);
            labelDescription.TabIndex = 2;
            labelDescription.TextAlign = ContentAlignment.MiddleLeft;
            labelDescription.Click += labelDescription_Click;
            // 
            // timerToast
            // 
            timerToast.Enabled = true;
            timerToast.Interval = 2000;
            timerToast.Tick += timerToast_Tick;
            // 
            // ToastForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 70);
            Controls.Add(labelDescription);
            Controls.Add(labelTitle);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ToastForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Toast";
            TopMost = true;
            Activated += ToastForm_Activated;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerToast;
        private Label labelTitle;
        private Label labelDescription;
    }
}