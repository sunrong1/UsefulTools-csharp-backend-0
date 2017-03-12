using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructure;

namespace UnitTestDavaTools
{
    [TestClass()]
    public class LinkedListTests
    {
        [TestMethod()]
        public void AppendTest()
        {
            
            LinkedListHead<string> linkTest = new LinkedListHead<string>();
            Assert.IsTrue(linkTest.Length() == 0);
            linkTest.Append("s");
            Assert.IsTrue(linkTest.Length() == 1);
        }

        [TestMethod()]
        public void IsEmptyTest()
        {
            LinkedListHead<string> linkTest = new LinkedListHead<string>();
            Assert.IsTrue(linkTest.IsEmpty());
        }

        [TestMethod()]
        public void DeleteTest()
        {
            LinkedListHead<string> linkTest = new LinkedListHead<string>();
            linkTest.Append("s");
            linkTest.Append("s");
            linkTest.Append("u");
            linkTest.Append("n");
            linkTest.Delete("s");
            Assert.IsTrue(linkTest.Length() == 3);
        }
    }
}
