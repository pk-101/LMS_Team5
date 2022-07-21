using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS_Team5.Model
{
    public class EmployeeDB
    {
        [Key]
        [Required]
        public int Emp_Id { get; set; }
        [ForeignKey("ManagerDB")]
        public virtual int Man_Id { get; set; }
        public virtual ManagerDB ManagerDB { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string Emp_Name { get; set; }
        [Required]
        public string Emp_Email { get; set; }
        [Required]
        public long Emp_Phone { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Emp_Doj { get; set; }
        [Required]
        public string Emp_Dept { get; set; }
        [Required]
        public int Emp_LeaveBal { get; set; }
    }
}
