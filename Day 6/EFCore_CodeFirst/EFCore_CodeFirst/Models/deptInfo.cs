using System.ComponentModel.DataAnnotations;

namespace EFCore_CodeFirst.Models
{
    public class deptInfo
    {
        [Key]
        public int deptNo { get; set; }

        public string deptName { get; set; }

        public string deptLocation { get; set;}

       

    }
}
