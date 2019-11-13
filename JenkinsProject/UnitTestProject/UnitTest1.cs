using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFunctions;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            throw new Exception();
            Assert.AreEqual(Functions.sum(3, 4), 7);
        }
    }
}
