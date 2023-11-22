using System.ComponentModel.DataAnnotations;

namespace EFCore_CodeFirst.Models
{
    public class EmployeeInfo
    {
        [Key]
        public int empNo { get; set; }
        public string empName { get; set; }
        public double empSalary { get; set; }
        public int empDept { get; set; }
        public bool empIsPermenant { get; set; }
    }
}
