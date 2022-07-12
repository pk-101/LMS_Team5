using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS_Team5.Model
{
    public class Employee
    {
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Email { get; set; }
        public long Emp_Phone { get; set; }
        public DateTime Emp_Doj { get; set; }
        public string Emp_Dept { get; set; }
        public int Emp_LeaveBal { get; set; }
    }
}
