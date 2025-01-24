using Employee_management_system.Code.Helper;
using Employee_management_system.Code.Models;
using Employee_management_system.Core;
using Employee_management_system.Data.EF;
using Employee_management_system.Gui.LoadingGui;

namespace Employee_management_system.Gui.UsersGui
{
    public partial class AddUserForm : Form
    {
        private readonly IDataHelper<Users> dataHelperForUser;
        private readonly IDataHelper<Roles> dataHelperForRoles;
        private readonly IDataHelper<SystemRecords> dataHelperForSystemRecords;
        private readonly Main main;
        private int Id;
        private DateTime UserCreatedDate;
        private readonly UsersUserControl page;

        public AddUserForm(Main main, int id, UsersUserControl page)
        {
            InitializeComponent();
            dataHelperForUser = new UsersEF();
            dataHelperForRoles = new RolesEF();
            dataHelperForSystemRecords = new SystemRecordsEF();

            this.Owner = main;

            AddSecondaryUser();
            SetRoles();
            this.main = main;
            this.Id = id;
            this.page = page;
            if (Id > 0)
                SetDataForEdit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void checkBoxSecondaryUser_CheckedChanged(object sender, EventArgs e)
        {
            if (Code.Models.LocalUser.Role == "Admin")
            {
                comboBoxUserId.Enabled = checkBoxSecondaryUser.Checked;
            }
            else
            {
                comboBoxUserId.Enabled = false;
            }

        }

        private void SetRoles()
        {

            if (Code.Models.LocalUser.Role == "Admin")
            {
                //Admin
                //Add Roles
                comboBoxRole.Items.Clear();
                comboBoxRole.Items.Add("Admin");
                comboBoxRole.Items.Add("User");
                comboBoxRole.Items.Add("Read");


                comboBoxUserId.Enabled = false;
                checkBoxSecondaryUser.Enabled = true;
                comboBoxRole.SelectedIndex = 1;
            }
            else
            {
                //User
                //Add Roles
                comboBoxRole.Items.Clear();
                comboBoxRole.Items.Add("User");
                comboBoxRole.Items.Add("Read");

                checkBoxSecondaryUser.Enabled = false;
                comboBoxUserId.Enabled = false;
                checkBoxSecondaryUser.Checked = true;
                comboBoxRole.SelectedIndex = 0;

            }
        }
        private void AddSecondaryUser()
        {
            comboBoxUserId.Items.Clear();
            comboBoxUserId.Items.Add(Code.Models.LocalUser.UserId);
            comboBoxUserId.SelectedIndex = 0;
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetRolesByMainRole();
        }

        private void SetRolesByMainRole()
        {

            if (comboBoxRole.SelectedItem.ToString() == "Admin")
            {
                checkBoxAdd.Checked = true;
                checkBoxDelete.Checked = true;
                checkBoxEdit.Checked = true;
                checkBoxExport.Checked = true;
                checkBoxPrint.Checked = true;
                checkBoxSearch.Checked = true;
                checkBoxHomeSearch.Checked = true;
                checkBoxHome.Checked = true;
                checkBoxSalary.Checked = true;
                checkBoxEmployees.Checked = true;
                checkBoxUsers.Checked = true;
                checkBoxReport.Checked = true;
                checkBoxSettings.Checked = true;
                checkBoxAbout.Checked = true;
                checkBoxHelp.Checked = true;
                checkBoxRetirment.Checked = true;
                checkBoxSystemRecords.Checked = true;
            }

            else if (comboBoxRole.SelectedItem.ToString() == "User")
            {
                checkBoxAdd.Checked = true;
                checkBoxDelete.Checked = true;
                checkBoxEdit.Checked = true;
                checkBoxExport.Checked = true;
                checkBoxPrint.Checked = true;
                checkBoxSearch.Checked = true;
                checkBoxHomeSearch.Checked = true;
                checkBoxHome.Checked = true;
                checkBoxSalary.Checked = true;
                checkBoxEmployees.Checked = true;
                checkBoxUsers.Checked = true;
                checkBoxReport.Checked = true;
                checkBoxSettings.Checked = true;
                checkBoxAbout.Checked = true;
                checkBoxHelp.Checked = true;
                checkBoxRetirment.Checked = true;
                checkBoxSystemRecords.Checked = true;

            }
            else //Read
            {
                checkBoxAdd.Checked = false;
                checkBoxDelete.Checked = false;
                checkBoxEdit.Checked = false;
                checkBoxExport.Checked = true;
                checkBoxPrint.Checked = true;
                checkBoxSearch.Checked = true;
                checkBoxHomeSearch.Checked = true;
                checkBoxHome.Checked = true;
                checkBoxSalary.Checked = true;
                checkBoxEmployees.Checked = true;
                checkBoxUsers.Checked = true;
                checkBoxReport.Checked = true;
                checkBoxSettings.Checked = true;
                checkBoxAbout.Checked = true;
                checkBoxHelp.Checked = true;
                checkBoxRetirment.Checked = true;
                checkBoxSystemRecords.Checked = true;

            }
        }

        private bool IsValid()
        {
            if (textBoxFullName.Text.Length < 3 ||
            textBoxUserName.Text.Length < 3 ||
            textBoxPassword.Text.Length < 3
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
            //Check the Fields
            if (!IsValid())
            {
                MsgHelper.ShowRequiredFields();
            }
            else
            {
                //Show loading
                LoadingForm.Instance(main).Show();

                //Check Connection
                if (await Task.Run(() => dataHelperForUser.ISCanConnect()))
                {
                    //check Dublicated Item
                    string fullName = textBoxFullName.Text;
                    string userName = textBoxUserName.Text;

                    var result = await Task.Run(() => dataHelperForUser
                    .GetAlDatal()
                    .Where(x => x.Id != Id)
                    .Where(x => x.FullName == fullName || x.Username == userName)
                    .FirstOrDefault() ?? new Users());

                    if (result.Id > 0)
                    {
                        //Msg
                        LoadingForm.Instance(main).Hide();
                        MsgHelper.ShowDuplicatedItems();
                    }
                    else
                    {
                        //Add
                        if (Id == 0)
                        {
                            Add();
                        }
                        else
                        {
                            //Edit
                            Edit();

                        }
                    }


                }
                else
                {
                    LoadingForm.Instance(main).Hide();
                    MsgHelper.ShowServerError();
                }

                LoadingForm.Instance(main).Hide();
            }
        }
        private async void Add()
        {
            //Set User
            Users users = new Users
            {
                FullName = textBoxFullName.Text,
                Username = textBoxUserName.Text,
                Password = textBoxPassword.Text,
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                CreatedDate = DateTime.Now.Date,
                EditedDate = DateTime.Now.Date,
                Role = comboBoxRole.SelectedItem.ToString() ?? "User",
                PhoneNumber = textBoxPhoneNumber.Text,
                IsSecondaryUser = checkBoxSecondaryUser.Checked,
                UserId = SetUserId()
            };
            //Send Data to DataBase
            var result = await Task.Run(() => dataHelperForUser.Add(users));
            if (result == "1")
            {

                //Add User Roles
                foreach (var item in flowLayoutPanelRoles.Controls)
                {
                    CheckBox checkBox = (CheckBox)item;
                    // Set
                    Roles roles = new Roles
                    {
                        Key = checkBox.Name,
                        Value = checkBox.Checked,
                        UsersId = users.Id

                    };

                    //Send
                    await Task.Run(() => dataHelperForRoles.Add(roles));

                }
                //Success
                SystemRecordHelper.Add("اضافة مستخدم", $" المستخدم الذي يحمل الرقم التعريفي: {users.Id} تم اضافته");
                page.LoadData();
                ToastHelper.ShowAddToast();
                

            }
            else
            {
                //MsgBox with result
                MessageBox.Show(result);

            }
        }

        private async void Edit()
        {
            //Set User
            Users users = new Users
            {
                Id = Id,
                FullName = textBoxFullName.Text,
                Username = textBoxUserName.Text,
                Password = textBoxPassword.Text,
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                CreatedDate = UserCreatedDate,
                EditedDate = DateTime.Now.Date,
                Role = comboBoxRole.SelectedItem.ToString() ?? "User",
                PhoneNumber = textBoxPhoneNumber.Text,
                IsSecondaryUser = checkBoxSecondaryUser.Checked,
                UserId = SetUserId()

            };
            //Send Data to DataBase
            var result = await Task.Run(() => dataHelperForUser.Edit(users));
            if (result == "1")
            {
                //Remove Old User Roles
                var oldRoles = await Task.Run(() => dataHelperForRoles
                .GetAlDatal().Where(x => x.UsersId == Id).ToList() ?? new List<Roles>());
                foreach (var role in oldRoles)
                {
                    await Task.Run(() => dataHelperForRoles.Delete(role.Id));

                }
                //Add User Roles
                foreach (var item in flowLayoutPanelRoles.Controls)
                {
                    CheckBox checkBox = (CheckBox)item;
                    // Set
                    Roles roles = new Roles
                    {
                        Key = checkBox.Name,
                        Value = checkBox.Checked,
                        UsersId = users.Id

                    };

                    //Sent
                    await Task.Run(() => dataHelperForRoles.Add(roles));
                }
                //Success
                SystemRecordHelper.Add("تعديل مستخدم", $" المستخدم الذي يحمل الرقم التعريفي:{users.Id} تم تعديله");

                page.LoadData();
                ToastHelper.ShowEditToast();
                this.Close();

            }
            else
            {
                //MsgBox with result
                MessageBox.Show(result);

            }
        }

        private string SetUserId()
        {
            if (checkBoxSecondaryUser.Checked)
            {
                return comboBoxUserId.SelectedItem.ToString() ?? LocalUser.UserId;
            }
            else
            {
                return Guid.NewGuid().ToString();
            }
        }

        private async void SetDataForEdit()
        {
            //Get Edit User Data
            var _user = await Task.Run(() => dataHelperForUser.Find(Id));
            if (_user != null)
            {
                textBoxFullName.Text = _user.FullName;
                textBoxUserName.Text = _user.Username;
                textBoxPassword.Text = _user.Password;
                textBoxEmail.Text = _user.Email;
                textBoxAddress.Text = _user.Address;
                textBoxPhoneNumber.Text = _user.PhoneNumber;
                comboBoxRole.SelectedItem = _user.Role;
                checkBoxSecondaryUser.Checked = _user.IsSecondaryUser;
                UserCreatedDate = _user.CreatedDate;

            }

            //Set Roles

            //Add User Roles
            foreach (var item in flowLayoutPanelRoles.Controls)
            {
                CheckBox checkBox = (CheckBox)item;

                checkBox.Checked = await Task.Run(() => dataHelperForRoles
                .GetAlDatal()
                .Where(x => x.UsersId == Id && x.Key == checkBox.Name)
                .Select(x => x.Value).FirstOrDefault());


            }
        }
    }
}
