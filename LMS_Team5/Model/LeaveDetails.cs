﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LMS_Team5.Model
{
    public class LeaveDetails
    {
        [Required]
        public int Leave_Id { get; set; }
        [Required]
        public int Emp_Id { get; set; }
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
