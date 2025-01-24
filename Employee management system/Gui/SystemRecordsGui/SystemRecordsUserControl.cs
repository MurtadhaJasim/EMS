using Employee_management_system.Code.Helper;
using Employee_management_system.Code.Models;
using Employee_management_system.Core;
using Employee_management_system.Data.EF;
using Employee_management_system.Gui.LoadingGui;
using System.Data;

namespace Employee_management_system.Gui.SystemRecordsGui

{

    public partial class SystemRecordsUserControl : UserControl
    {
        private static SystemRecordsUserControl? systemRecordsUserControl;

        private static Main _main;
        private IDataHelper<SystemRecords> DataHelper;
        private List<SystemRecords> data;
        private List<int> IdDeleteList;


        public SystemRecordsUserControl()
        {
            InitializeComponent();
            DataHelper = new SystemRecordsEF();
            data = new List<SystemRecords>();
            IdDeleteList = new List<int>();


            LoadData();
        }

        public static SystemRecordsUserControl Instance(Main main)
        {
            _main = main;
            return systemRecordsUserControl ?? (systemRecordsUserControl = new SystemRecordsUserControl());
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check Data if not empty
                if (!DataGridViewHelper.IsEmpty(dataGridView1))
                {

                    // Get Id
                    SetIdDeleteList();
                    if (IdDeleteList.Count > 0)
                    {
                        if (MsgHelper.ShowDeleteDialog())
                        {
                            LoadingForm.Instance(_main).Show();
                            if (await Task.Run(() => DataHelper.ISCanConnect()))
                            {
                                // Loop into Id List
                                foreach (int Id in IdDeleteList)
                                {
                                    await Task.Run(() => DataHelper.Delete(Id));

                                }
                                ToastHelper.ShowDeleteToast();
                                LoadData();
                            }
                            else
                            {
                                LoadingForm.Instance(_main).Hide();
                                MsgHelper.ShowServerError();
                            }

                            LoadingForm.Instance(_main).Hide();
                        }
                    }
                    else
                    {
                        MsgHelper.ShowDeleteSelectRow();
                    }
                }

                else
                {
                    LoadingForm.Instance(_main).Hide();
                    MsgHelper.ShowEmptyDataGridView();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        private async void buttonExport_Click(object sender, EventArgs e)
        {
            //show Loading

            LoadingForm.Instance(_main).Show();
            if (await Task.Run(() => DataHelper.ISCanConnect()))
            {
                //Start Load Data
                //Check if Admin or not
                if (LocalUser.Role == "Admin")
                {
                    //Get All Data
                    data = await Task.Run(() => DataHelper.GetAlDatal());

                }
                else
                {
                    //Get Data By User
                    data = await Task.Run(() => DataHelper.GetDataByUser(LocalUser.UserId));
                }
                LoadingForm.Instance(_main).Hide();

                ExportExcel(data);

            }

            else
            {
                //No Connection
                LoadingForm.Instance(_main).Hide();
                ShowServerErrorState();
                MsgHelper.ShowServerError();


            }


            //Hide Loading
            LoadingForm.Instance(_main).Hide();

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        //Method
        public async void LoadData()
        {
            //show Loading

            LoadingForm.Instance(_main).Show();
            if (await Task.Run(() => DataHelper.ISCanConnect()))
            {
                //Start Load Data
                //Check if Admin or not
                if (LocalUser.Role == "Admin")
                {
                    //Get All Data
                    data = await Task.Run(() => DataHelper.GetAlDatal());

                }
                else
                {
                    //Get Data By User
                    data = await Task.Run(() => DataHelper.GetDataByUser(LocalUser.UserId));
                }
                labelNoOfItems.Text = data.Count.ToString();
                //Fill DataGridView
                dataGridView1.DataSource = data.Take(Properties.Settings.Default.NumberOfDataGridViewItems).ToList();
                if (data.Count <= Properties.Settings.Default.NumberOfDataGridViewItems)
                {
                    comboBoxNumberOfPages.Items.Clear();
                    comboBoxNumberOfPages.Items.Add(0);
                }
                else
                {
                    //Set Number Of Pages
                    double value = Convert.ToDouble(data.Count) / Convert.ToDouble(Properties.Settings.Default.NumberOfDataGridViewItems);
                    int noOfPage = Convert.ToInt32(Math.Round(value, MidpointRounding.AwayFromZero));
                    comboBoxNumberOfPages.Items.Clear();
                    for (int i = 0; i <= noOfPage; i++)
                    {
                        comboBoxNumberOfPages.Items.Add(i);
                    }
                }


                //Set Columns Title
                SetColumns();

                //Show Empty Data
                ShowEmptyDataState();

                //Clear data
                data.Clear();
                LoadingForm.Instance(_main).Hide();

            }

            else
            {
                //No Connection
                LoadingForm.Instance(_main).Hide();
                ShowServerErrorState();
                MsgHelper.ShowServerError();


            }


            //Hide Loading
            LoadingForm.Instance(_main).Hide();


        }

        public async void Search()
        {
            //show Loading
            //loading.Show();
            LoadingForm.Instance(_main).Show();
            if (await Task.Run(() => DataHelper.ISCanConnect()))
            {
                //Start Load Data
                string SearchItem = textBoxSearch.Text;
                //Check if Admin or not
                if (LocalUser.Role == "Admin")
                {
                    //Get All Data
                    data = await Task.Run(() => DataHelper.SearchAll(SearchItem));

                }
                else
                {
                    //Get Data By User
                    data = await Task.Run(() => DataHelper.SearchByUser(LocalUser.UserId, SearchItem));
                }

                //Fill DataGridView
                dataGridView1.DataSource = data.ToList();

                //Set Columns Title
                //SetColumns();

                //Show Empty Data
                ShowEmptyDataState();

                //Clear data
                data.Clear();
                LoadingForm.Instance(_main).Hide();

            }

            else
            {
                //No Connection
                LoadingForm.Instance(_main).Hide();
                ShowServerErrorState();
                MsgHelper.ShowServerError();


            }


            //Hide Loading
            LoadingForm.Instance(_main).Hide();


        }
        private void ShowEmptyDataState()
        {
            //Set a title and a description
            labelStateTitle.Text = Properties.Resources.EmptyDataStateTitle;
            labelStateDescription.Text = Properties.Resources.EmptyDataStateDescription;
            panelState.Visible = DataGridViewHelper.IsEmpty(dataGridView1);
        }
        private void ShowServerErrorState()
        {
            //Set a title and a description
            labelStateTitle.Text = Properties.Resources.ServerErrorTitle;
            labelStateDescription.Text = Properties.Resources.ServerErrorDescription;
            panelState.Visible = true;
        }

        private void SetColumns()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "المعرف";
            dataGridView1.Columns[1].HeaderCell.Value = "الاسم الكامل";
            dataGridView1.Columns[2].HeaderCell.Value = "اسم الجهاز";
            dataGridView1.Columns[3].HeaderCell.Value = "MAC";
            dataGridView1.Columns[4].HeaderCell.Value = "الصلاحية ";
            dataGridView1.Columns[5].HeaderCell.Value = "الوصف";
            dataGridView1.Columns[6].HeaderCell.Value = "تاريخ الحركة";
            dataGridView1.Columns[7].HeaderCell.Value = "العنوان";
        }

        private void labelEmptyData_Click(object sender, EventArgs e)
        {

        }

        private void SetIdDeleteList()
        {
            IdDeleteList.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    IdDeleteList.Add(Convert.ToInt32(row.Cells[0].Value));
                }
            }

        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Prevent the beep sound
                e.SuppressKeyPress = true; // Suppress default behavior
                Search();
            }
        }


        private void textBoxSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void comboBoxNumberOfPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //show Loading

                LoadingForm.Instance(_main).Show();
                if (await Task.Run(() => DataHelper.ISCanConnect()))
                {
                    //Start Load Data
                    //Check if Admin or not
                    if (LocalUser.Role == "Admin")
                    {
                        //Get All Data
                        data = await Task.Run(() => DataHelper.GetAlDatal());

                    }
                    else
                    {
                        //Get Data By User
                        data = await Task.Run(() => DataHelper.GetDataByUser(LocalUser.UserId));
                    }

                    //Get and set parameters
                    var idList = data.Select(x => x.Id).ToArray();
                    int index = comboBoxNumberOfPages.SelectedIndex;
                    int noOfItemIndex = index * Properties.Settings.Default.NumberOfDataGridViewItems;

                    //Fill DataGridView
                    dataGridView1.DataSource = data.Where(x => x.Id <= idList[noOfItemIndex])
                        .Take(Properties.Settings.Default.NumberOfDataGridViewItems).ToList();


                    //Show Empty Data
                    ShowEmptyDataState();

                    //Clear data
                    data.Clear();
                    LoadingForm.Instance(_main).Hide();

                }

                else
                {
                    //No Connection
                    LoadingForm.Instance(_main).Hide();
                    ShowServerErrorState();
                    MsgHelper.ShowServerError();


                }


                //Hide Loading
                LoadingForm.Instance(_main).Hide();



            }
            catch
            {

            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxNumberOfPages.SelectedIndex != 0)
                {
                    comboBoxNumberOfPages.SelectedIndex--;
                }
            }
            catch { }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                comboBoxNumberOfPages.SelectedIndex++;
            }
            catch { }
        }

        private void buttonExportDataGridView_Click(object sender, EventArgs e)
        {
            //Get Data
            var data = (List<SystemRecords>)dataGridView1.DataSource;
            ExportExcel(data);

        }
        private void ExportExcel(List<SystemRecords> data)
        {
            //Define DataTable
            DataTable dataTable = new DataTable();



            //Convert to Datatable
            using (var reader = FastMember.ObjectReader.Create(data))
            {
                dataTable.Load(reader);
            }

            //Re-set DataTable
            dataTable = arrangedDataTable(dataTable);

            //Send to Export
            ExcelHelper.Export(dataTable, "SystemRecords");
        }

        private DataTable arrangedDataTable(DataTable dataTable)
        {
            dataTable.Columns["Id"].SetOrdinal(0);
            dataTable.Columns["Id"].ColumnName = "ت";

            dataTable.Columns["UserFullName"].SetOrdinal(1);
            dataTable.Columns["UserFullName"].ColumnName = "الاسم الكامل";


            dataTable.Columns["DeviceName"].SetOrdinal(2);
            dataTable.Columns["DeviceName"].ColumnName = "اسم الجهاز";


            dataTable.Columns["MachinId"].SetOrdinal(3);
            dataTable.Columns["MachinId"].ColumnName = "MAC ";

            dataTable.Columns["Title"].SetOrdinal(4);
            dataTable.Columns["Title"].ColumnName = "العنوان";

            dataTable.Columns["Description"].SetOrdinal(5);
            dataTable.Columns["Description"].ColumnName = "وصف الحركة  ";

            dataTable.Columns["CreatedDate"].SetOrdinal(6);
            dataTable.Columns["CreatedDate"].ColumnName = "تاريخ الحركة ";

            dataTable.Columns["UsersId"].SetOrdinal(7);
            dataTable.Columns["UsersId"].ColumnName = "معرف المستخدم  ";


            return dataTable;
        }
    }
}

