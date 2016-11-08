using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample.Examples
{
    public class FooCollection
    {
        private List<IFoo> elements;
        public FooCollection()
        {
            elements = new List<IFoo>();
        }
        public void Add(IFoo element)
        {
            elements.Add(element);
        }

        public IFoo Get(int index)
        {
            if(Count <= index) {
                return null;
            }
            return elements[index];
        }

        public string GetJoinedString()
        {
            StringBuilder sb = new StringBuilder();
            elements.ForEach(foo => sb.Append(foo.Bar));
            return sb.ToString();
        }

        public string GetJoinedStringContain(char check)
        {
            StringBuilder sb = new StringBuilder();
            var contains = elements.Where(foo => foo.Bar.Contains(check)).ToList();
            contains.ForEach(foo => sb.Append(foo.UseBar()));
            return sb.ToString();
        }
        

        public int Count {
            get {
                return elements.Count;
            }
        }
    }
}
