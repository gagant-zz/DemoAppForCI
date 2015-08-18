using DemoAppForCI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoAppForCI.DataAccess
{
    public class IntialiseContext : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Employee> emp = new List<Employee>()
            {
            
            new Employee{EmpID=101,DeptID=1,FirstName="Tanvir",LastName="Kaur"},
            new Employee{EmpID=102,DeptID=2,FirstName="jfkj",LastName="fdssd"}
            };
            emp.ForEach(x => context.Employee.Add(x));
            context.SaveChanges();


            List<Department> dept = new List<Department>()
            {
                new Department{DeptID=1,DeptName="Operations"},
                new Department{DeptID=2,DeptName="Services"}
            };

            dept.ForEach(x => context.Department.Add(x));
            context.SaveChanges();
        }
    }
}