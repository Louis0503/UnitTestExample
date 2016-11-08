using System.Collections.Generic;

namespace UnitTestExample.Examples.InMemoryTest
{
    public class Department
    {
        public int DepartmentId {
            get; set;
        }
        public string Name {
            get; set;
        }

        public ICollection<Employee> Employees {
            get; set;
        }
    }
}
