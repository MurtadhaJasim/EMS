using Employee_management_system.Core;
using Employee_management_system.Data;

namespace Employee_management_system.Code.Helper
{
    public static class ConStringHelper
    {


        public static void SetConString()
        {
            string server = Properties.Settings.Default.Server;
            string db = Properties.Settings.Default.DataBase;


            if (Properties.Settings.Default.ConType == "local")
            {

                Data.ConString.ConStringValue = $"Server={server};Database={db};Encrypt=false;Trusted_Connection=True;";
            }
            else
            {
                string user = Properties.Settings.Default.UserName;
                string password = Properties.Settings.Default.Password;
                string druation = Properties.Settings.Default.ConDuration.ToString();
                ConString.ConStringValue = $"Server={server};Database={db};User Id={user};Password={password};Encrypt=false;Timeout={druation};";

            }
        }

    }
}