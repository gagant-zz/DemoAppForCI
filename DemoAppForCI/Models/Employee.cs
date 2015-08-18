using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoAppForCI.Models
{
    public class Employee
    {
        [Key]
        [DisplayName("Employee Id")]
        [Required(ErrorMessage = "Emp Id is required")]
        public int EmpID { get; set; }

        [StringLength(20, ErrorMessage = "First Name should be less than 20 characters")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [StringLength(20, ErrorMessage = "Last Name should be less than 20 characters")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }


        [DisplayName("Department")]
        public int DeptID { get; set; }
    }
}