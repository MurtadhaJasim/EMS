namespace Employee_management_system.Code.Helper
{
    public static class MsgHelper
    {
        public static void ShowServerError()
        {
            MessageBox.Show("لا يمكن الاتصال بالسيرفر يرجئ المحاولة مرة اخرى", "عدم توفر الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowRequiredFields()
        {
            MessageBox.Show("جميع الحقول التي تتضمن علامة * هي حقول مطلوبة. تـاكد من ادخالها واعد المحاولة مرة اخرى", "حقول مطلوبة", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowDuplicatedItems()
        {
            MessageBox.Show("تم اضافة هذه البيانات بالفعل. تأكد من تغيير بيانات بعض الحقول ثم اعد المحاولة", "بيانات مكرره", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowEmptyDataGridView()
        {
            MessageBox.Show("لاجراء هذه العملية يجب أن تختار بيانات", "لا يوجد بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowDeleteSelectRow()
        {
            MessageBox.Show("لحساسية اجراء الحذف يجب عليك ان تختار كامل السطر", "اجراء الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static bool ShowDeleteDialog()
        {
            var result = MessageBox.Show("هل انت متأكد من هذا الاجراء ؟ لا يمكن استرجاع البيانات", "اجراء الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void ShowNumberValid()
        {
            MessageBox.Show("قم بادخال قيمة رقمية فقط", "ادخال غير صحيح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
