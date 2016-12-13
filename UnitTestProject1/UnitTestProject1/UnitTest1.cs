using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int q1 = 6;
           int q2 = Class1.Test1(2, 3);
            Assert.AreEqual(q1, q2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string q1 = "Проверка теста";
            string q2 = Class1.Test2("Проверка ", "теста");
            Assert.AreEqual(q1, q2);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int q1 = 5;
            int q2 = Class1.Test3(7, 2);
            Assert.AreEqual(q1, q2);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int q1 = 4;
            int q2 = Class1.Test4(12,3);
            Assert.AreEqual(q1, q2);
        }

    }
}
