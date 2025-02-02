﻿using Employee_management_system.Code.Helper;
using Employee_management_system.Code.Models;
using Employee_management_system.Core;
using Employee_management_system.Data.EF;
using Employee_management_system.Gui.LoadingGui;
using System.Data;
using System.Windows.Forms;

namespace Employee_management_system.Gui.EmployeesRecordGui
{
    public partial class EmployeesRecordUserControl : UserControl
    {
        private static Main _main;
        private IDataHelper<EmployeesRecords> dataHelper;
        private List<EmployeesRecords> data;
        private List<int> IdDeleteList;
        private Employees employees;

        public EmployeesRecordUserControl(Employees employees)
        {
            InitializeComponent();
            dataHelper = new EmployeesRecordsRecordsEF();
            data = new List<EmployeesRecords>();
            IdDeleteList = new List<int>();
            LoadData();
            this.employees = employees;
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
                            if (await Task.Run(() => dataHelper.ISCanConnect()))
                            {
                                // Loop into Id List
                                foreach (int Id in IdDeleteList)
                                {
                                    await Task.Run(() => dataHelper.Delete(Id));
                                    SystemRecordHelper.Add("حذف علاوة",
                   $"تم حذف علاوة حالية الذي تحمل الرقم التعريفي {Id.ToString()}");
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void buttonExport_Click(object sender, EventArgs e)
        {
            // Show Loading
            LoadingForm.Instance(_main).Show();
            if (await Task.Run(() => dataHelper.ISCanConnect()))
            {
                // Start Load Data
                // Check if Admin or not
                if (LocalUser.Role == "Admin")
                {
                    // Get All Data
                    data = await Task.Run(() => dataHelper.GetDataByUser(LocalUser.UserId).Where(x => x.EmployeesId == employees.Id).ToList());
                }
                else
                {
                    // Get Data By User
                    data = await Task.Run(() => dataHelper.GetDataByUser(LocalUser.UserId).Where(x => x.EmployeesId == employees.Id).ToList());
                }
                LoadingForm.Instance(_main).Hide();

                ExportExcel(data);
            }
            else
            {
                // No Connection
                LoadingForm.Instance(_main).Hide();
                ShowServerErrorState();
                MsgHelper.ShowServerError();
            }

            // Hide Loading
            LoadingForm.Instance(_main).Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Methods
        public async void LoadData()
        {
            // Show Loading
            LoadingForm.Instance(_main).Show();
            if (await Task.Run(() => dataHelper.ISCanConnect()))
            {
                // Start Load Data
                // Check if Admin or not
                if (LocalUser.Role == "Admin")
                {
                    // Get All Data
                    data = await Task.Run(() => dataHelper.GetDataByUser(LocalUser.UserId).Where(x => x.EmployeesId == employees.Id).ToList());
                }
                else
                {
                    // Get Data By User
                    data = await Task.Run(() => dataHelper.GetDataByUser(LocalUser.UserId).Where(x => x.EmployeesId == employees.Id).ToList());
                }
                labelNoOfItems.Text = data.Count.ToString();
                // Fill DataGridView
                dataGridView1.DataSource = data.Take(Properties.Settings.Default.NumberOfDataGridViewItems).ToList();
                if (data.Count <= Properties.Settings.Default.NumberOfDataGridViewItems)
                {
                    comboBoxNumberOfPages.Items.Clear();
                    comboBoxNumberOfPages.Items.Add(0);

                }
                else
                {
                    // Get and Add No of pages
                    double value = Convert.ToDouble(data.Count) / Convert.ToDouble(Properties.Settings.Default.NumberOfDataGridViewItems);
                    int noOfPage = Convert.ToInt32(Math.Round(value, MidpointRounding.AwayFromZero));
                    comboBoxNumberOfPages.Items.Clear();
                    for (int i = 0; i <= noOfPage; i++)
                    {
                        comboBoxNumberOfPages.Items.Add(i);
                    }
                }


                //
                // Set Columns Title
                SetColumns();

                // Show Empty Data
                ShowEmptyDataState();

                // Clear Data
                data.Clear();
                LoadingForm.Instance(_main).Hide();
            }
            else
            {
                // No Connection
                LoadingForm.Instance(_main).Hide();
                ShowServerErrorState();
                MsgHelper.ShowServerError();
            }

            // Hide Loading
            LoadingForm.Instance(_main).Hide();


        }

        public async void Search()
        {
            // Show Loading
            LoadingForm.Instance(_main).Show();
            if (await Task.Run(() => dataHelper.ISCanConnect()))
            {
                // Start Load Data
                string searchItem = textBoxSearch.Text;
                // Check if Admin or not
                if (LocalUser.Role == "Admin")
                {
                    // Get All Data
                    data = await Task.Run(() => dataHelper.SearchByUser(LocalUser.UserId, searchItem));
                }
                else
                {
                    // Get Data By User
                    data = await Task.Run(() => dataHelper.SearchByUser(LocalUser.UserId, searchItem));
                }

                // Fill DataGridView
                dataGridView1.DataSource = data.ToList();


                // Set Columns Title
                //SetColumns();

                // Show Empty Data
                ShowEmptyDataState();

                // Clear Data
                data.Clear();
                LoadingForm.Instance(_main).Hide();
            }
            else
            {
                // No Connection
                LoadingForm.Instance(_main).Hide();
                ShowServerErrorState();
                MsgHelper.ShowServerError();
            }

            // Hide Loading
            LoadingForm.Instance(_main).Hide();


        }

        private void ShowEmptyDataState()
        {
            // Set Title and Descripton
            labelStateTitle.Text = Properties.Resources.EmptyDataStateTitle;
            labelStateDescription.Text = Properties.Resources.EmptyDataStateDescription;
            panelState.Visible = DataGridViewHelper.IsEmpty(dataGridView1);
        }

        private void ShowServerErrorState()
        {
            // Set Title and Descripton
            labelStateTitle.Text = Properties.Resources.ServerErrorTitle;
            labelStateDescription.Text = Properties.Resources.ServerErrorDescription;
            panelState.Visible = true;
        }

        private void SetColumns()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "المعرف";
            dataGridView1.Columns[1].HeaderCell.Value = "الاسم الكامل";
            dataGridView1.Columns[2].HeaderCell.Value = "العنوان الوظيفي";
            dataGridView1.Columns[3].HeaderCell.Value = "الحالة";
            dataGridView1.Columns[4].Visible = false;

            dataGridView1.Columns[5].HeaderCell.Value = "درجة-ح";
            dataGridView1.Columns[6].HeaderCell.Value = "مرحلة-ح";
            dataGridView1.Columns[7].HeaderCell.Value = "راتب-ح";
            dataGridView1.Columns[8].HeaderCell.Value = "التاريخ-ح";

            dataGridView1.Columns[9].HeaderCell.Value = "درجة-ق";
            dataGridView1.Columns[10].HeaderCell.Value = "مرحلة-ق";
            dataGridView1.Columns[11].HeaderCell.Value = "راتب-ق";
            dataGridView1.Columns[12].HeaderCell.Value = "التاريخ-ق";

            // Visible of Columns
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;

        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private async void comboBoxNumberOfPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Show Loading
                LoadingForm.Instance(_main).Show();
                if (await Task.Run(() => dataHelper.ISCanConnect()))
                {
                    // Start Load Data
                    // Check if Admin or not
                    if (LocalUser.Role == "Admin")
                    {
                        // Get All Data
                        data = await Task.Run(() => dataHelper.GetDataByUser(LocalUser.UserId).Where(x => x.EmployeesId == employees.Id).ToList());
                    }
                    else
                    {
                        // Get Data By User
                        data = await Task.Run(() => dataHelper.GetDataByUser(LocalUser.UserId).Where(x => x.EmployeesId == employees.Id).ToList());
                    }

                    // Get and Set Param
                    var idlist = data.Select(x => x.Id).ToArray();
                    int index = comboBoxNumberOfPages.SelectedIndex;
                    int noOfItemIndex = index * Properties.Settings.Default.NumberOfDataGridViewItems;

                    // Fill DataGridView
                    dataGridView1.DataSource = data.Where(x => x.Id <= idlist[noOfItemIndex])
                        .Take(Properties.Settings.Default.NumberOfDataGridViewItems).ToList();

                    // Show Empty Data
                    ShowEmptyDataState();

                    // Clear Data
                    data.Clear();
                    LoadingForm.Instance(_main).Hide();
                }
                else
                {
                    // No Connection
                    LoadingForm.Instance(_main).Hide();
                    ShowServerErrorState();
                    MsgHelper.ShowServerError();
                }

                // Hide Loading
                LoadingForm.Instance(_main).Hide();

            }
            catch { }

        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxNumberOfPages.SelectedIndex != 0)
                {
                    comboBoxNumberOfPages.SelectedIndex = comboBoxNumberOfPages.SelectedIndex - 1;
                }
            }
            catch { }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {

                comboBoxNumberOfPages.SelectedIndex = comboBoxNumberOfPages.SelectedIndex + 1;

            }
            catch { }
        }

        private void buttonExportDataGridView_Click(object sender, EventArgs e)
        {
            // Get Data
            var data = (List<EmployeesRecords>)dataGridView1.DataSource;
            ExportExcel(data);

        }

        private void ExportExcel(List<EmployeesRecords> data)
        {
            // Define Data Table
            DataTable dataTable = new DataTable();

            // Convert to Data Table
            using (var reader = FastMember.ObjectReader.Create(data))
            {
                dataTable.Load(reader);
            }

            // Re-Set DataTable
            dataTable = arrangedDataTable(dataTable);

            // Send to export
            ExcelHelper.Export(dataTable, "EmployeesRecords");
        }
        private DataTable arrangedDataTable(DataTable dataTable)
        {
            dataTable.Columns["Id"].SetOrdinal(0);
            dataTable.Columns["Id"].ColumnName = "المعرف";

            dataTable.Columns["Name"].SetOrdinal(1);
            dataTable.Columns["Name"].ColumnName = "الاسم الكامل";

            dataTable.Columns["JobTitle"].SetOrdinal(2);
            dataTable.Columns["JobTitle"].ColumnName = "العنوان الوظيفي";

            dataTable.Columns["EmpState"].SetOrdinal(3);
            dataTable.Columns["EmpState"].ColumnName = "الحالة";

            dataTable.Columns["LastPromotionDate"].SetOrdinal(4);
            dataTable.Columns["LastPromotionDate"].ColumnName = "LastPromotionDate";

            dataTable.Columns["CurrentDegree"].SetOrdinal(5);
            dataTable.Columns["CurrentDegree"].ColumnName = "درجة-ح";

            dataTable.Columns["CurrentStage"].SetOrdinal(6);
            dataTable.Columns["CurrentStage"].ColumnName = "مرحلة-ح";

            dataTable.Columns["CurrentSalary"].SetOrdinal(7);
            dataTable.Columns["CurrentSalary"].ColumnName = $"راتب-ح {Properties.Settings.Default.Currency}";

            dataTable.Columns["CurrentDate"].SetOrdinal(8);
            dataTable.Columns["CurrentDate"].ColumnName = "التاريخ-ح";

            dataTable.Columns["NextDegree"].SetOrdinal(9);
            dataTable.Columns["NextDegree"].ColumnName = "درجة-ق";

            dataTable.Columns["NextStage"].SetOrdinal(10);
            dataTable.Columns["NextStage"].ColumnName = "مرحلة-ق";

            dataTable.Columns["NextSalary"].SetOrdinal(11);
            dataTable.Columns["NextSalary"].ColumnName = $"راتب-ق {Properties.Settings.Default.Currency}";

            dataTable.Columns["NextDate"].SetOrdinal(12);
            dataTable.Columns["NextDate"].ColumnName = "التاريخ-ق";

            dataTable.Columns["Note"].SetOrdinal(13);
            dataTable.Columns["Note"].ColumnName = "ملاحظات";

            dataTable.Columns["AddedDate"].SetOrdinal(14);
            dataTable.Columns["AddedDate"].ColumnName = "AddedDate";

            dataTable.Columns["UpdateDate"].SetOrdinal(15);
            dataTable.Columns["UpdateDate"].ColumnName = "UpdateDate";


            // Removed columns
            dataTable.Columns.Remove("UsersId");
            dataTable.Columns.Remove("BookThanks");
            dataTable.Columns.Remove("EmployeesRecords");

            return dataTable;
        }
    }
}