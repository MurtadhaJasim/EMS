using Employee_management_system.Code.Models;
using Employee_management_system.Core;
using Employee_management_system.Data.EF;
using System.Net.NetworkInformation;

namespace Employee_management_system.Code.Helper
{
    public static class SystemRecordHelper
    {
        public static void Add(string title, string description)
        {
            IDataHelper<SystemRecords> dataHelper = new SystemRecordsEF();
            SystemRecords systemRecords = new SystemRecords
            {
                CreatedDate = DateTime.Now,
                Description = description,
                Title = title,
                DeviceName = Environment.UserName,
                UserFullName = LocalUser.FullName,
                UsersId = LocalUser.Id,
                MachinId = GetMachineId(),
            };
            dataHelper.Add(systemRecords);
        }

        private static string GetMachineId()
        {
            var networkinterfaces = NetworkInterface.GetAllNetworkInterfaces();
            var machineid = string.Empty;
            foreach (var networkinterface in networkinterfaces)
            {
                if (networkinterface.OperationalStatus == OperationalStatus.Up &&
                    networkinterface.NetworkInterfaceType != NetworkInterfaceType.Tunnel &&
                    networkinterface.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    machineid = networkinterface.GetPhysicalAddress().ToString();
                }
            }

            if (machineid == string.Empty)
            {
                machineid = "Not Found";
            }

            return machineid;
        }



    }
}
