using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Fibo
{
    [TestClass]
    public class FiboManageTest
    {
        [TestMethod]
        public void FibReq_CorrectAnswer_Test()
        {
            int n = 2;
            int expected = 1;
            int actual = FiboManage.FibReq(n);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FibReq_UncorrectAnswer_Test()
        {
            int n = 2;
            int expected = 2;
            int actual = FiboManage.FibReq(n);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FibCyc_CorrectAnswer_Test()
        {
            int x = 2;
            int expected = 1;
            int actual = FiboManage.FibReq(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FibCyc_UncorrectAnswer_Test()
        {
            int x = 2;
            int expected = 2;
            int actual = FiboManage.FibReq(x);
            Assert.AreEqual(expected, actual);
        }
    }
}
