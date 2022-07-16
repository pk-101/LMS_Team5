using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMS_Team5.Model
{
    public class ManagerDB
    {
        [Key]
        [Required]
        public int Man_Id { get; set; }
        [Required]
        public string Man_Name { get; set; }
        [Required]
        public string Man_Email { get; set; }
        [Required]
        public long Man_Phone { get; set; }
    }
}
