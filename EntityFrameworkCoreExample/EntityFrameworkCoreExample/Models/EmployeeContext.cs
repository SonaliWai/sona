using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreExample.Models
{
    public class EmployeeContext:DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual  DbSet<Location> Locations { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=WAIANGDESK12;Initial Catalog=EmpManagement;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        
    }
}
