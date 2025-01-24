namespace Employee_management_system.Core
{
    public class Roles
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public bool Value { get; set; }

        //Navigation properties
        public int UsersId { get; set; }
        public Users Users { get; set; }

    }
}
