namespace Employee_management_system.Core
{
    public class Employees
    {
        public int Id { get; set; }

        //Generated Data
        public string Name { get; set; }
        public string JopTitle { get; set; }
        public string EmpState { get; set; }
        public DateTime LastPromotionDate { get; set; }

        //Current Bonus
        public int CurrentDegree { get; set; }
        public int CurrentStage { get; set; }
        public float CurrentSalary { get; set; }
        public DateTime CurrentDate { get; set; }

        //Next Bonus
        public int NextDegree { get; set; }
        public int NextStage { get; set; }
        public float NextSalary { get; set; }
        public DateTime NextDate { get; set; }

        //Other Data
        public string Note { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdateDate { get; set; }

        //Relations
        public string UsersId { get; set; }
        public List<BookThanks> BookThanks { get; set; }
        public List<EmployeesRecords> EmployeesRecords { get; set; }


    }
}
