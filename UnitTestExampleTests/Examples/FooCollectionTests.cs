using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExample.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace UnitTestExample.Examples.Tests
{
    class FooDummy : IFoo
    {
        public string Bar {
            get {
                return null;
            }
            set {
                ;
            }
        }

        public string UseBar()
        {
            return Bar;
        }
    }
    class FooStub : IFoo
    {
        public string Bar {
            get {
                return "TestStub";
            }
            set {
                ;
            }
        }
        public string UseBar()
        {
            return Bar;
        }
    }

    class FooSpy : IFoo
    {
        private string bar = string.Empty;
        public bool isUsed = false;
        public string Bar {
            get {
                return bar;
            }
            set {
                bar = value;
            }
        }
        public string UseBar()
        {
            isUsed = true;
            return Bar;
        }
    }
    [TestClass()]
    public class FooCollectionTests
    {
        [TestMethod()]
        public void FooCollectionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddTestDummy()
        {
            //arrange
            var tartget = new FooCollection();
            tartget.Add(new FooDummy());
            tartget.Add(new FooDummy());
            var expected = 2;
            //act
            var actual = tartget.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetJoinedStringTest()
        {
            //arrange
            var tartget = new FooCollection();
            tartget.Add(new FooStub());
            tartget.Add(new FooStub());
            var expected = "TestStubTestStub";
            //act
            var actual = tartget.GetJoinedString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetJoinedStringTestUseMock()
        {
            //arrange
            var tartget = new FooCollection();
            var fooMock = new Mock<IFoo>();
            fooMock.Setup(foo => foo.Bar)
                .Returns("TestStub");

            tartget.Add(fooMock.Object);
            tartget.Add(fooMock.Object);
            var expected = "TestStubTestStub";
            //act
            var actual = tartget.GetJoinedString();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetJoinedStringContainTest()
        {
            //arrange
            var tartget = new FooCollection();
            var spy1 = new FooSpy { Bar = "12312" };
            var spy2 = new FooSpy { Bar = "00000" };
            tartget.Add(spy1);
            tartget.Add(spy2);
            //act
            tartget.GetJoinedStringContain('0');
            //assert
            Assert.AreEqual(false, spy1.isUsed);
            Assert.AreEqual(true, spy2.isUsed);
        }
    }
}