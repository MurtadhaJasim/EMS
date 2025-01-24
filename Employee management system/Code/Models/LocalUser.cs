using Employee_management_system.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_management_system.Code.Models
{
    internal static class LocalUser
    {
        public static int Id { get; set; }
        public static string FullName { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Role { get; set; }
        public static bool IsSecondaryUser { get; set; }
        public static string UserId { get; set; }
        public static string? PhoneNumber { get; set; }
        public static string? Email { get; set; }
        public static string? Address { get; set; }
        public static DateTime CreatedDate { get; set; }
        public static DateTime EditedDate { get; set; }

        //Navigation properties
        public static List<Roles> Roles { get; set; }
        public static List<SystemRecords> SystemRecords { get; set; }
    }
}
