using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LMS_Team5.Model
{
    public class LeaveDetailsDB
    {
        [Key]
        [Required]
        public int Leave_Id { get; set; }
        [Required]
        [ForeignKey("EmployeeDB")]
        public virtual int Emp_Id { get; set; }
        public virtual EmployeeDB EmployeeDB { get; set; }
        [Required]
        public int No_OfDays { get; set; }
        [Required]
        public DateTime Start_Date { get; set; }
        [Required]
        public DateTime End_Date { get; set; }
        [Required]
        public DateTime Applied_On { get; set; }
        [Required]
        public string Leave_Type { get; set; }
        [Required]
        public string Leave_Status { get; set; }
        [Required]
        public string Leave_Reason { get; set; }
        [Required]
        public string Manager_Comment { get; set; }
    }
}
