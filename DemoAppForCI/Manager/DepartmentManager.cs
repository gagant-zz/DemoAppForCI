using DemoAppForCI.DataAccess;
using DemoAppForCI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoAppForCI.Manager
{
    public class DepartmentManager
    {


        public void SaveDept(Department dept)
        {
            using (var _deptContext = new DataContext())
            {
                _deptContext.Department.Add(dept);
                _deptContext.SaveChanges();
            }
        }

        public void DeleteDept(int deptId)
        {
            var deptToDelete = GetDept(deptId);
            if (null != deptToDelete)
            {
                using (var _deptContext = new DataContext())
                {
                    _deptContext.Department.Remove(deptToDelete);
                    _deptContext.SaveChanges();
                }
            }
        }

        public Department GetDept(int deptId)
        {
            using (var _deptContext = new DataContext())
            {
                return _deptContext.Department.Where(x => x.DeptID == deptId).SingleOrDefault();
            }
        }

        public void EditDept(Department deptToEdit)
        {
            using (var _deptContext = new DataContext())
            {
                var selectedDEpt = _deptContext.Department.Where(x => x.DeptID == deptToEdit.DeptID).SingleOrDefault();
                selectedDEpt.DeptName = deptToEdit.DeptName;
                _deptContext.SaveChanges();
            }

        }

        public IEnumerable<Department> DeptRepo()
        {
            using (var _deptContext = new DataContext())
            {
                var data = _deptContext.Department;
                var retVal = data.ToList();
                return retVal;

            }

        }

        public SelectList DeptDDl()
        {
            return new SelectList(DeptRepo(), "DeptID", "DeptName");
        }

        public string GetDepartmentName(int deptid)
        {
            var dept = DeptRepo().Where(x => x.DeptID == deptid).SingleOrDefault();
            return dept.DeptName;
        }

    }
}