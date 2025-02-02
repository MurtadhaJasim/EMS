﻿namespace Employee_management_system.Gui.SystemRecordsGui
{
    partial class SystemRecordsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            flowLayoutPanelNavBar = new FlowLayoutPanel();
            buttonDelete = new Button();
            buttonExportAll = new Button();
            buttonExportDataGridView = new Button();
            panel1 = new Panel();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            dataGridView1 = new DataGridView();
            labelStateTitle = new Label();
            panelState = new Panel();
            labelStateDescription = new Label();
            buttonRefresh = new Button();
            toolTip1 = new ToolTip(components);
            buttonPrev = new Button();
            buttonNext = new Button();
            comboBoxNumberOfPages = new ComboBox();
            panel2 = new Panel();
            labelNoOfItems = new Label();
            flowLayoutPanelNavBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelState.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.Controls.Add(buttonDelete);
            flowLayoutPanelNavBar.Controls.Add(buttonExportAll);
            flowLayoutPanelNavBar.Controls.Add(buttonExportDataGridView);
            flowLayoutPanelNavBar.Controls.Add(panel1);
            flowLayoutPanelNavBar.Dock = DockStyle.Top;
            flowLayoutPanelNavBar.Location = new Point(0, 0);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new Padding(5);
            flowLayoutPanelNavBar.RightToLeft = RightToLeft.Yes;
            flowLayoutPanelNavBar.Size = new Size(1062, 64);
            flowLayoutPanelNavBar.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = Properties.Resources.Delete;
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(949, 8);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 50);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "  حذف";
            toolTip1.SetToolTip(buttonDelete, "حدد سطر واحد او اكثر للحذف");
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonExportAll
            // 
            buttonExportAll.Image = Properties.Resources.Excel;
            buttonExportAll.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExportAll.Location = new Point(843, 8);
            buttonExportAll.Name = "buttonExportAll";
            buttonExportAll.Size = new Size(100, 50);
            buttonExportAll.TabIndex = 3;
            buttonExportAll.Text = "  الكل";
            toolTip1.SetToolTip(buttonExportAll, "تصدير كامل البيانات");
            buttonExportAll.UseVisualStyleBackColor = true;
            buttonExportAll.Click += buttonExport_Click;
            // 
            // buttonExportDataGridView
            // 
            buttonExportDataGridView.Image = Properties.Resources.Excel;
            buttonExportDataGridView.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExportDataGridView.Location = new Point(737, 8);
            buttonExportDataGridView.Name = "buttonExportDataGridView";
            buttonExportDataGridView.Size = new Size(100, 50);
            buttonExportDataGridView.TabIndex = 5;
            buttonExportDataGridView.Text = "  الشبكة";
            toolTip1.SetToolTip(buttonExportDataGridView, "تصدير شبكة عرض البيانات");
            buttonExportDataGridView.UseVisualStyleBackColor = true;
            buttonExportDataGridView.Click += buttonExportDataGridView_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(buttonSearch);
            panel1.Location = new Point(383, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 50);
            panel1.TabIndex = 4;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = DockStyle.Fill;
            textBoxSearch.Location = new Point(50, 0);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(298, 50);
            textBoxSearch.TabIndex = 2;
            textBoxSearch.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(textBoxSearch, "اكتب عبارة بحث او اضغط بحث بشكل مباشر لعرض كافة البيانات");
            textBoxSearch.TextChanged += textBoxSearch_TextChanged_1;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // buttonSearch
            // 
            buttonSearch.Dock = DockStyle.Left;
            buttonSearch.Image = Properties.Resources.Search;
            buttonSearch.Location = new Point(0, 0);
            buttonSearch.Margin = new Padding(6, 4, 6, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(50, 50);
            buttonSearch.TabIndex = 1;
            toolTip1.SetToolTip(buttonSearch, "اكتب عبارة بحث او اضغط بح بشكل مباشر لعرض كافة البيانات");
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Size = new Size(1062, 542);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // labelStateTitle
            // 
            labelStateTitle.BackColor = Color.White;
            labelStateTitle.Dock = DockStyle.Top;
            labelStateTitle.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStateTitle.ForeColor = Color.Gray;
            labelStateTitle.Location = new Point(0, 0);
            labelStateTitle.Name = "labelStateTitle";
            labelStateTitle.Size = new Size(586, 47);
            labelStateTitle.TabIndex = 5;
            labelStateTitle.Text = "لا يوجد بيانات ";
            labelStateTitle.TextAlign = ContentAlignment.MiddleCenter;
            labelStateTitle.Click += labelEmptyData_Click;
            // 
            // panelState
            // 
            panelState.Anchor = AnchorStyles.None;
            panelState.BackColor = Color.White;
            panelState.Controls.Add(labelStateDescription);
            panelState.Controls.Add(labelStateTitle);
            panelState.Location = new Point(238, 232);
            panelState.Name = "panelState";
            panelState.Size = new Size(586, 142);
            panelState.TabIndex = 6;
            panelState.Visible = false;
            // 
            // labelStateDescription
            // 
            labelStateDescription.BackColor = Color.White;
            labelStateDescription.Dock = DockStyle.Top;
            labelStateDescription.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStateDescription.ForeColor = Color.LightGray;
            labelStateDescription.Location = new Point(0, 47);
            labelStateDescription.Name = "labelStateDescription";
            labelStateDescription.Size = new Size(586, 47);
            labelStateDescription.TabIndex = 6;
            labelStateDescription.Text = "لا يوجد بيانات ";
            labelStateDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRefresh.Image = Properties.Resources.Refresh;
            buttonRefresh.Location = new Point(999, 553);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(50, 50);
            buttonRefresh.TabIndex = 5;
            toolTip1.SetToolTip(buttonRefresh, "أعادة التحميل");
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonPrev
            // 
            buttonPrev.Image = Properties.Resources.Right;
            buttonPrev.Location = new Point(158, 0);
            buttonPrev.Name = "buttonPrev";
            buttonPrev.Size = new Size(50, 50);
            buttonPrev.TabIndex = 6;
            toolTip1.SetToolTip(buttonPrev, "الصفحة السابقة");
            buttonPrev.UseVisualStyleBackColor = true;
            buttonPrev.Click += buttonPrev_Click;
            // 
            // buttonNext
            // 
            buttonNext.Image = Properties.Resources.Left;
            buttonNext.Location = new Point(0, 0);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(50, 50);
            buttonNext.TabIndex = 7;
            toolTip1.SetToolTip(buttonNext, "الصفحة التالية");
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // comboBoxNumberOfPages
            // 
            comboBoxNumberOfPages.BackColor = Color.White;
            comboBoxNumberOfPages.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNumberOfPages.DropDownWidth = 105;
            comboBoxNumberOfPages.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxNumberOfPages.FormattingEnabled = true;
            comboBoxNumberOfPages.Location = new Point(56, 10);
            comboBoxNumberOfPages.Name = "comboBoxNumberOfPages";
            comboBoxNumberOfPages.RightToLeft = RightToLeft.Yes;
            comboBoxNumberOfPages.Size = new Size(96, 33);
            comboBoxNumberOfPages.TabIndex = 8;
            toolTip1.SetToolTip(comboBoxNumberOfPages, "عدد الصفحات");
            comboBoxNumberOfPages.SelectedIndexChanged += comboBoxNumberOfPages_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labelNoOfItems);
            panel2.Controls.Add(comboBoxNumberOfPages);
            panel2.Controls.Add(buttonNext);
            panel2.Controls.Add(buttonPrev);
            panel2.Location = new Point(3, 553);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 50);
            panel2.TabIndex = 6;
            // 
            // labelNoOfItems
            // 
            labelNoOfItems.BackColor = Color.White;
            labelNoOfItems.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNoOfItems.ForeColor = Color.DimGray;
            labelNoOfItems.Location = new Point(214, 4);
            labelNoOfItems.Name = "labelNoOfItems";
            labelNoOfItems.Size = new Size(59, 39);
            labelNoOfItems.TabIndex = 9;
            labelNoOfItems.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SystemRecordsUserControl
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(buttonRefresh);
            Controls.Add(panelState);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SystemRecordsUserControl";
            Size = new Size(1062, 606);
            flowLayoutPanelNavBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelState.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelNavBar;
        private Button buttonDelete;
        private Button buttonExportAll;
        private Panel panel1;
        private Button buttonSearch;
        private DataGridView dataGridView1;
        private Label labelStateTitle;
        private Panel panelState;
        private Label labelStateDescription;
        private Button buttonRefresh;
        private ToolTip toolTip1;
        public TextBox textBoxSearch;
        private Button buttonExportDataGridView;
        private Panel panel2;
        private Button buttonNext;
        private Button buttonPrev;
        private ComboBox comboBoxNumberOfPages;
        private Label labelNoOfItems;
    }
}
