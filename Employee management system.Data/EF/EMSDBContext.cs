using Employee_management_system.Core;
using Microsoft.EntityFrameworkCore;

namespace Employee_management_system.Data.DBContext
{
    public class EMSDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          // string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EMSDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            optionsBuilder.UseSqlServer(ConString.ConStringValue);
        }
        // Tables
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<SystemRecords> SystemRecords { get; set; }
        public DbSet<SalaryRate> SalaryRate { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<BookThanks> BookThanks { get; set; }
        public DbSet<EmployeesRecords> EmployeesRecords { get; set; }

    }


}
