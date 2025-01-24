using ClosedXML.Excel;
using System.Data;

namespace Employee_management_system.Code.Helper
{
    public static class ExcelHelper
    {
        public static void Export(DataTable dataTable, string sheetName)
        {
            //Define Save Dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Excel File (.xlsx)|*.xlsx";
            saveFileDialog.Title = "Export Excel File";

            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Export
                try
                {
                    using (XLWorkbook xLWorkbook = new XLWorkbook())
                    {
                        xLWorkbook.AddWorksheet(dataTable, sheetName);
                        using (MemoryStream ma = new MemoryStream())
                        {
                            xLWorkbook.SaveAs(ma);
                            File.WriteAllBytes(saveFileDialog.FileName, ma.ToArray());

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}

