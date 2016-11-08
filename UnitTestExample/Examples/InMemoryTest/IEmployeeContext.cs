using System.Data.Entity;

namespace UnitTestExample.Examples.InMemoryTest
{
    public interface IEmployeeContext
    {
        IDbSet<Department> Departments {
            get;
        }
        IDbSet<Employee> Employees {
            get;
        }
        int SaveChanges();
    }
}
