using DemoAppForCI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoAppForCI.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=ConnectionString")
        {

        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}