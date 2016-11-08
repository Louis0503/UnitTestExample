using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestExample.Examples.InMemoryTest.Tests
{
    [TestClass()]
    public class DepartmentControllerTests
    {
        [TestMethod()]
        public void IndexOrdersByName()
        {
            var context = new FakeEmployeeContext {
                Departments ={
                    new Department { Name = "BBB"},
                    new Department { Name = "AAA"},
                    new Department { Name = "ZZZ"},}
            };

            var target = new DepartmentController(context);
            var result = target.Index();

            Assert.IsInstanceOfType(result.ViewData.Model, typeof(IEnumerable<Department>));

            var departments = (IEnumerable<Department>)result.ViewData.Model;
            Assert.AreEqual("AAA", departments.ElementAt(0).Name);
            Assert.AreEqual("BBB", departments.ElementAt(1).Name);
            Assert.AreEqual("ZZZ", departments.ElementAt(2).Name);
        }
    }
}