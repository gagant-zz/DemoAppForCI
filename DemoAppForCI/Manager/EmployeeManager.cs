using DemoAppForCI.DataAccess;
using DemoAppForCI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAppForCI.Manager
{
    public class EmployeeManager
    {
        DataContext empContext;
        public EmployeeManager()
        {
            empContext = new DataContext();
        }
        public void SaveEmp(Employee emp)
        {
            empContext.Employee.Add(emp);
            empContext.SaveChanges();
        }

        public Employee EmpDetails(int empId)
        {
            return empContext.Employee.Where(x => x.EmpID == empId).SingleOrDefault();
        }

        public void RemoveEmp(int empId)
        {
            var empDelete = EmpDetails(empId);
            if (empDelete != null)
            {
                empContext.Employee.Remove(empDelete);
                empContext.SaveChanges();
            }
        }

        public void EditEmp(Employee emp)
        {
            var selectedEmp = empContext.Employee.Where(x => x.EmpID == emp.EmpID).SingleOrDefault();
            selectedEmp.FirstName = emp.FirstName;
            selectedEmp.LastName = emp.LastName;
            selectedEmp.DeptID = emp.DeptID;
            empContext.SaveChanges();
        }

        public IEnumerable<Employee> EmpRepo()
        {
            return empContext.Employee.ToList();
        }



    }

}