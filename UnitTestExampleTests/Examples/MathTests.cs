using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExample.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample.Examples.Tests
{
    [TestClass()]
    public class MathTests
    {
        [TestMethod()]
        public void MaxTest()
        {
            //arrange
            var target = new Math();
            var input1 = 1;
            var input2 = 2;
            var expected = 2;
            //act
            var actual = target.Max(input1, input2);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest2()
        {
            //arrange
            var target = new Math();
            var input1 = 1;
            var input2 = 2;
            var expected = 3;
            //act
            var actual = target.Max(input1, input2);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}