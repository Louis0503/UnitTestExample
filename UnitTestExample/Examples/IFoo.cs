using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample.Examples
{
    public interface IFoo
    {
        string Bar {
            get; set;
        }
        string UseBar();
    }
}
