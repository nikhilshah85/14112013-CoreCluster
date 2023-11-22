using Microsoft.EntityFrameworkCore;

namespace EFCore_CodeFirst.Models
{
    public class EmployeeManagementDBContext : DbContext
    {

        public DbSet<deptInfo> DepartmentInfo { get; set; }

        public DbSet<EmployeeInfo> EmployeeInfo { get; set; }

        public DbSet<ClientInfo> ClientInfo { get; set; }


        public EmployeeManagementDBContext()
        {
                
        }


        public EmployeeManagementDBContext(DbContextOptions options) : base(options) 
        {
        
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("server=NIKHILPC\\TRAINING_SERVER;database=ManageEmployeeDB;integrated security=true;trustservercertificate=true");
            }
        }

    }
}
