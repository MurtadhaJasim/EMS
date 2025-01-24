namespace Employee_management_system.Core
{
    public class SystemRecords
    {
        public int Id { get; set; }
        public string UserFullName { get; set; }
        public string DeviceName { get; set; }
        public string MachinId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }


        //Navigation properties
        public int UsersId { get; set; }

    }
}
