using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eManager.Domain
{
    public class Department
    {
        public virtual int Id { set; get; }
        public virtual string Name { set; get; }
        public virtual ICollection<Employee> Employees { set; get;}
    }
}
