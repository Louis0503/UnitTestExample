using System.Linq;

namespace UnitTestExample.Examples.InMemoryTest
{
    public class FakeDepartmentSet : FakeDbSet<Department>
    {
        public override Department Find(params object[] keyValues)
        {
            return this.SingleOrDefault(d => d.DepartmentId == (int)keyValues.Single());
        }
    }
}
