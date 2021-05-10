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
            //n = 2;
            if (n == 1 || n == 0)
            {
                return n;
            }
            int numFib=FibReq(n - 1) + FibReq(n - 2);
            return numFib;
        }

        static int FibCyc(int x, int y)
        {
            //x = 0;
            //y = 1;
            //int temp = 0;
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
