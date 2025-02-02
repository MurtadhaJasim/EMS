using Employee_management_system.Code.Helper;
namespace Employee_management_system
{
    public partial class Main : Form
    {
        private PageHelper pageHelper;
        public Main()
        {
            InitializeComponent();

            pageHelper = new PageHelper(this);

            //Set HomePage
            pageHelper.SetPage(Gui.HomeGui.HomeUserControl.Instance());


            //Get And Set The Window State
            SetScreenState(Properties.Settings.Default.IsMaxScreen);
            SetRoles();
        }

        // Test
        private void SetRoles()
        {
            /*
            Code.Models.LocalUser.UserId = "123";
            Code.Models.LocalUser.Id = 1;
            Code.Models.LocalUser.Role = "Admin";
            Code.Models.LocalUser.FullName = "Murtadha Jasim";
            Code.Models.LocalUser.Username = "Murtadha";
            */

        }

        private void SetScreenState(bool IsMax)
        {
            if (IsMax)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;

        }



        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveWindowStateSettings();
            Application.Exit();

        }

        private void SaveWindowStateSettings()
        {
            //Save Window State
            if (WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.IsMaxScreen = true;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.IsMaxScreen = false;
                Properties.Settings.Default.Save();
            }
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            pageHelper.SetPage(Gui.HomeGui.HomeUserControl.Instance());
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            pageHelper.SetPage(Gui.UsersGui.UsersUserControl.Instance(this));
        }

        private void buttonSystemRecords_Click(object sender, EventArgs e)
        {
            pageHelper.SetPage(Gui.SystemRecordsGui.SystemRecordsUserControl.Instance(this));
        }

        private void buttonSalaryCategory_Click(object sender, EventArgs e)
        {
            pageHelper.SetPage(Gui.SalaryRateGui.SalaryRateUserControl.Instance(this));

        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            pageHelper.SetPage(Gui.EmployeesGui.EmployeesUserControl.Instance(this));

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Gui.SettingsGui.SettingForm settingForm = new Gui.SettingsGui.SettingForm();
            settingForm.Show();
        }
    }
}
