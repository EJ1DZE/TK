using Microsoft.VisualStudio.TestTools.UnitTesting;
using TK;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var page = new MainWindow();
            Assert.AreEqual(page.Test(8, 45, 7, 8));
            Assert.AreEqual(page.Test(10, 50, 30, 10));
        }
    }
}
