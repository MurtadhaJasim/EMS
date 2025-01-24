using Employee_management_system.Data.DBContext;
using Employee_management_system.Gui.UsersGui;

namespace Employee_management_system
{
    partial class StartForm : Form
    {
        private EMSDBContext db;
        public StartForm()
        {
            InitializeComponent();
            Code.Helper.ConStringHelper.SetConString();
        }

        private void linkLabelSetServer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show Settings From
            Gui.SettingsGui.SettingForm settingForm = new Gui.SettingsGui.SettingForm();
            settingForm.Show();
        }

        private void linkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private async void timerStart_Tick(object sender, EventArgs e)
        {
            db = new EMSDBContext();

            // Check the con
            labelState.Text = "جاري الاتصال..";
            if (await db.Database.CanConnectAsync())
            {
                // Show Login From
                timerStart.Enabled = false;
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                Hide();
            }
            else
            {
                panelSettings.Visible = true;
                labelState.Text = "فشل الاتصال ... سنعاود الاتصال بعد لحظات";
            }
        }
    }
}