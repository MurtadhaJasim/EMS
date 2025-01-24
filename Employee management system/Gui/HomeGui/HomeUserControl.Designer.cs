namespace Employee_management_system.Gui.HomeGui
{
    partial class HomeUserControl
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
            labelWelcome = new Label();
            labelCompnayName = new Label();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.Anchor = AnchorStyles.None;
            labelWelcome.Location = new Point(383, 284);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(249, 69);
            labelWelcome.TabIndex = 0;
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCompnayName
            // 
            labelCompnayName.Anchor = AnchorStyles.None;
            labelCompnayName.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCompnayName.Location = new Point(344, 138);
            labelCompnayName.Name = "labelCompnayName";
            labelCompnayName.Size = new Size(326, 103);
            labelCompnayName.TabIndex = 1;
            labelCompnayName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelCompnayName);
            Controls.Add(labelWelcome);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "HomeUserControl";
            Size = new Size(1062, 606);
            ResumeLayout(false);
        }

        #endregion

        private Label labelWelcome;
        private Label labelCompnayName;
    }
}
