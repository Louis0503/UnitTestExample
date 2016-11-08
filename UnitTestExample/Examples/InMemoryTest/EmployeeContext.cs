using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace UnitTestExample.Examples.InMemoryTest
{
    public class EmployeeContext : DbContext, IEmployeeContext
    {
        public IDbSet<Department> Departments {
            get; set;
        }
        public IDbSet<Employee> Employees {
            get; set;
        }
    }
}
