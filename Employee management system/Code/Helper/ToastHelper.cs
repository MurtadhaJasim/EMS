using Employee_management_system.Gui.ToastGui;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.CompilerServices;

namespace Employee_management_system.Code.Helper
{
    public static class ToastHelper
    {



        public static void ShowAddToast()
        {
            ToastForm.Instance("اضافة بيانات", "تم اضافة البيانات بنجاح ").Show();
        }
        public static void ShowEditToast()
        {
            ToastForm.Instance("تعديل بيانات", "تم تعديل البيانات بنجاح ").Show();
        }
        public static void ShowDeleteToast()
        {
            ToastForm.Instance("حذف بيانات", "تم حذف البيانات بنجاح ").Show();
        }
    }
}
