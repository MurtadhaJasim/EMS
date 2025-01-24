

namespace Employee_management_system
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            flowLayoutPanelNavBar = new FlowLayoutPanel();
            buttonHome = new Button();
            buttonSalaryCategory = new Button();
            buttonEmployees = new Button();
            buttonRetirment = new Button();
            buttonUsers = new Button();
            buttonReport = new Button();
            buttonSystemRecords = new Button();
            buttonSettings = new Button();
            buttonHelp = new Button();
            buttonAbout = new Button();
            panelContainer = new Panel();
            toolTip1 = new ToolTip(components);
            flowLayoutPanelNavBar.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.Controls.Add(buttonHome);
            flowLayoutPanelNavBar.Controls.Add(buttonSalaryCategory);
            flowLayoutPanelNavBar.Controls.Add(buttonEmployees);
            flowLayoutPanelNavBar.Controls.Add(buttonRetirment);
            flowLayoutPanelNavBar.Controls.Add(buttonUsers);
            flowLayoutPanelNavBar.Controls.Add(buttonReport);
            flowLayoutPanelNavBar.Controls.Add(buttonSystemRecords);
            flowLayoutPanelNavBar.Controls.Add(buttonSettings);
            flowLayoutPanelNavBar.Controls.Add(buttonHelp);
            flowLayoutPanelNavBar.Controls.Add(buttonAbout);
            flowLayoutPanelNavBar.Dock = DockStyle.Bottom;
            flowLayoutPanelNavBar.Location = new Point(0, 621);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new Padding(3);
            flowLayoutPanelNavBar.Size = new Size(1069, 51);
            flowLayoutPanelNavBar.TabIndex = 0;
            flowLayoutPanelNavBar.DockChanged += Main_Load;
            flowLayoutPanelNavBar.Paint += flowLayoutPanel1_Paint;
            // 
            // buttonHome
            // 
            buttonHome.Image = Properties.Resources.Home;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(916, 7);
            buttonHome.Margin = new Padding(6, 4, 6, 4);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(120, 36);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "الرئيسية";
            toolTip1.SetToolTip(buttonHome, "الصفحة الرئيسية");
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonSalaryCategory
            // 
            buttonSalaryCategory.Image = Properties.Resources.Payroll;
            buttonSalaryCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalaryCategory.Location = new Point(784, 7);
            buttonSalaryCategory.Margin = new Padding(6, 4, 6, 4);
            buttonSalaryCategory.Name = "buttonSalaryCategory";
            buttonSalaryCategory.Size = new Size(120, 36);
            buttonSalaryCategory.TabIndex = 1;
            buttonSalaryCategory.Text = "السلم";
            toolTip1.SetToolTip(buttonSalaryCategory, "ادارة سلم الرواتب");
            buttonSalaryCategory.UseVisualStyleBackColor = true;
            buttonSalaryCategory.Click += buttonSalaryCategory_Click;
            // 
            // buttonEmployees
            // 
            buttonEmployees.Image = Properties.Resources.Staff;
            buttonEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEmployees.Location = new Point(652, 7);
            buttonEmployees.Margin = new Padding(6, 4, 6, 4);
            buttonEmployees.Name = "buttonEmployees";
            buttonEmployees.Size = new Size(120, 36);
            buttonEmployees.TabIndex = 2;
            buttonEmployees.Text = "  الموظفين";
            toolTip1.SetToolTip(buttonEmployees, "ادارة الموظفين");
            buttonEmployees.UseVisualStyleBackColor = true;
            buttonEmployees.Click += buttonEmployees_Click;
            // 
            // buttonRetirment
            // 
            buttonRetirment.Image = Properties.Resources.Retired;
            buttonRetirment.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRetirment.Location = new Point(520, 7);
            buttonRetirment.Margin = new Padding(6, 4, 6, 4);
            buttonRetirment.Name = "buttonRetirment";
            buttonRetirment.Size = new Size(120, 36);
            buttonRetirment.TabIndex = 8;
            buttonRetirment.Text = "   المتقاعدين";
            toolTip1.SetToolTip(buttonRetirment, "معلومات المتقاعدين");
            buttonRetirment.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            buttonUsers.Image = Properties.Resources.Users;
            buttonUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUsers.Location = new Point(388, 7);
            buttonUsers.Margin = new Padding(6, 4, 6, 4);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(120, 36);
            buttonUsers.TabIndex = 3;
            buttonUsers.Text = "المستخدم";
            toolTip1.SetToolTip(buttonUsers, "ادارة المستخدمين");
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonReport
            // 
            buttonReport.Image = Properties.Resources.Report;
            buttonReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReport.Location = new Point(256, 7);
            buttonReport.Margin = new Padding(6, 4, 6, 4);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(120, 36);
            buttonReport.TabIndex = 4;
            buttonReport.Text = "التقارير";
            toolTip1.SetToolTip(buttonReport, "توليد تقارير النظام");
            buttonReport.UseVisualStyleBackColor = true;
            // 
            // buttonSystemRecords
            // 
            buttonSystemRecords.Image = Properties.Resources.Records;
            buttonSystemRecords.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSystemRecords.Location = new Point(124, 7);
            buttonSystemRecords.Margin = new Padding(6, 4, 6, 4);
            buttonSystemRecords.Name = "buttonSystemRecords";
            buttonSystemRecords.Size = new Size(120, 36);
            buttonSystemRecords.TabIndex = 9;
            buttonSystemRecords.Text = "    سجل النظام";
            toolTip1.SetToolTip(buttonSystemRecords, "سجل حركات النظام");
            buttonSystemRecords.UseVisualStyleBackColor = true;
            buttonSystemRecords.Click += buttonSystemRecords_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Image = Properties.Resources.Settings;
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(916, 51);
            buttonSettings.Margin = new Padding(6, 4, 6, 4);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(120, 36);
            buttonSettings.TabIndex = 5;
            buttonSettings.Text = "  الاعدادات";
            toolTip1.SetToolTip(buttonSettings, "ضبط الاعدادات العامه للبرنامج");
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = Properties.Resources.Help;
            buttonHelp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHelp.Location = new Point(784, 51);
            buttonHelp.Margin = new Padding(6, 4, 6, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(120, 36);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "  المساعدة";
            toolTip1.SetToolTip(buttonHelp, "مساعدة حول النظام");
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            buttonAbout.Image = Properties.Resources.About;
            buttonAbout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbout.Location = new Point(652, 51);
            buttonAbout.Margin = new Padding(6, 4, 6, 4);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(120, 36);
            buttonAbout.TabIndex = 7;
            buttonAbout.Text = "  حول";
            toolTip1.SetToolTip(buttonAbout, "حول النظام واخر التحديثات");
            buttonAbout.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1069, 621);
            panelContainer.TabIndex = 1;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 672);
            Controls.Add(panelContainer);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee management system";
            WindowState = FormWindowState.Maximized;
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            flowLayoutPanelNavBar.ResumeLayout(false);
            ResumeLayout(false);
        }





        #endregion

        private FlowLayoutPanel flowLayoutPanelNavBar;
        private Button buttonHome;
        private Button buttonSalaryCategory;
        private Button buttonEmployees;
        private Button buttonUsers;
        private Button buttonReport;
        private Button buttonSettings;
        private Button buttonHelp;
        private Button buttonAbout;
        public Panel panelContainer;
        private ToolTip toolTip1;
        private Button buttonRetirment;
        private Button buttonSystemRecords;
    }
}
