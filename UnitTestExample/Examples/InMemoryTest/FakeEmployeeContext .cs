﻿using System.Data.Entity;

namespace UnitTestExample.Examples.InMemoryTest
{
    public class FakeEmployeeContext : IEmployeeContext
    {
        public FakeEmployeeContext()
        {
            this.Departments = new FakeDepartmentSet();
            this.Employees = new FakeEmployeeSet();
        }

        public IDbSet<Department> Departments {
            get; private set;
        }

        public IDbSet<Employee> Employees {
            get; private set;
        }

        public int SaveChanges()
        {
            return 0;
        }
    }
}
