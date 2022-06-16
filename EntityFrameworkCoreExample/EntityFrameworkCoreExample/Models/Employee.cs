using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCoreExample.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        [Column("employee_id")]
        public int Id { get; set; }
        [Column("employee_name")]
        public string Name { get; set; }    

        [Column("department_ref_id")]
        public int DepartmentRefId { get; set; }
        [Column("salary")]
        public int Salary { get; set; }
        [Column("adrees")]
        public string Address { get; set; }
    }
}
