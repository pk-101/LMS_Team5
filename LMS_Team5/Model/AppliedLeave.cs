﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS_Team5.Model
{
    public class AppliedLeave
    {
        [Required]
        public int Applied_Leave_Id { get; set; }
        [Required]
        public int Leave_Id { get; set; }
        [Required]
        public int No_OfDays { get; set; }
        [Required]
        public DateTime Start_Date { get; set; }
        [Required]
        public DateTime End_Date { get; set; }
        [Required]
        public string Leave_Type { get; set; }
        [Required]
        public string Leave_Status { get; set; }
        [Required]
        public string Leave_Reason { get; set; }
    }
}
