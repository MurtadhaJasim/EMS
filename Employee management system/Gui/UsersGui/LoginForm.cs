using Employee_management_system.Code.Helper;
using Employee_management_system.Code.Models;
using Employee_management_system.Core;
using Employee_management_system.Data.EF;
using System.Data;

namespace Employee_management_system.Gui.UsersGui
{
    public partial class LoginForm : Form
    {
        private readonly IDataHelper<Core.Users> dataHelperForUser;
        private readonly IDataHelper<Roles> dataHelperForRoles;
        private readonly IDataHelper<SystemRecords> dataHelperForSystemRecords;
        Main main;
        public LoginForm()
        {
            InitializeComponent();

            dataHelperForUser = new UsersEF();
            dataHelperForRoles = new RolesEF();
            dataHelperForSystemRecords = new SystemRecordsEF();
        }


        private bool IsValid()
        {
            if (

                textBoxPassword.Text.Length < 3 ||
                textBoxUserName.Text.Length < 3
                )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            // Check the fields
            if (!IsValid())
            {
                MsgHelper.ShowRequiredFields();
            }
            else
            {
                // Show Loading
                pictureBoxLoding.Visible = true;
                // Check Connection
                if (await Task.Run(() => dataHelperForUser.ISCanConnect()))
                {

                    Login();

                }

                else
                {
                    pictureBoxLoding.Visible = false;

                    MsgHelper.ShowServerError();
                }

                pictureBoxLoding.Visible = false;

            }

        }

        private async void Login()
        {

            // Check user Name and Password
            string userName = textBoxUserName.Text,
                    password = textBoxPassword.Text;
            Core.Users user = await Task.Run(() =>
            dataHelperForUser.GetAlDatal()
            .Where(x => x.Username == userName && x.Password == password).FirstOrDefault() ?? new Core.Users());
            if (user.Id > 0)
            {
                // Set User Info
                LocalUser.Id = user.Id;
                LocalUser.Username = user.Username;
                LocalUser.Password = user.Password;
                LocalUser.Address = user.Address;
                LocalUser.UserId = user.UserId;
                LocalUser.FullName = user.FullName;
                LocalUser.Email = user.Email;
                LocalUser.IsSecondaryUser = user.IsSecondaryUser;

                // Get and set roles
                RolesHelper.localRoles = await Task.Run(() => dataHelperForRoles
                    .GetAlDatal()
                    .Where(x => x.UsersId == user.Id).ToList());

                // Success
                SystemRecordHelper.Add("تسجيل الدخول",
                    $"تم تسجيل دخول مستخدم     {user.FullName}");

                Main main = new Main();
                main.Show();
                Hide();
            }
            else
            {

                MessageBox.Show("معلومات تسجيل الدخول خاطئة", "خطأ في تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}