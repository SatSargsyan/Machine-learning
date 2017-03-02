using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 7;
            int K = 5;
            int P = 1;

            Console.WriteLine(minNum(A, K, P));
            Console.ReadKey();
        }

        static int minNum(int A, int K, int P)
        {
                                  
            if (K - A >= 0)
            {
                return P / (K - A) + 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
