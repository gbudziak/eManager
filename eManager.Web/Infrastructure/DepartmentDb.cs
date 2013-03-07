using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eManager.Domain;

namespace eManager.Web.Infrastructure
{
    public class DepartmentDb : DbContext, IDepartmentDataSource
    {
        public DepartmentDb() : base("DefaultConnection")
        {

        }
 
        public DbSet<Employee> Employees { set; get; }
        public DbSet<Department> Departments { set; get; }

        void IDepartmentDataSource.Save() {
            SaveChanges();
        }

        IQueryable<Employee> IDepartmentDataSource.Employees
        {
            get { return Employees; }
        }

        IQueryable<Department> IDepartmentDataSource.Departments
        {
            get { return Departments; }
        }
    }
}