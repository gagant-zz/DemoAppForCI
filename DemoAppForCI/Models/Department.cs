using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoAppForCI.Models
{
    public class Department
    {
        [Key]
        [DisplayName("Department Id")]
        [Required(ErrorMessage = "DeptID is required")]
        public int DeptID { get; set; }

        [StringLength(10, ErrorMessage = "Dpartment name should be less than 10 characters")]
        [DisplayName("Department Name")]
        public string DeptName { get; set; }
    }
}