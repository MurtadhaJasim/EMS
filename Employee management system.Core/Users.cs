namespace Employee_management_system.Core
{
    public class Users
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool IsSecondaryUser { get; set; }
        public string UserId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EditedDate { get; set; }

        //Navigation properties
        public List<Roles> Roles { get; set; }

    }
}
