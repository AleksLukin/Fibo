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
/////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo
{
    public static class FiboManage
    {
        public static int FibReq(int n)
        {
            
            if (n == 1 || n == 0)
            {
                return n;
            }
            int numFib=FibReq(n - 1) + FibReq(n - 2);
            return numFib;
        }

        static int FibCyc(int x, int y)
        {
            int n = 2;

            for (int i = 0; i < n; i++)
            {
                int temp = x;
                x = y;
                y += temp;
            }
            return y;
        }
    }
}
