using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello worldddd";
            string s2 = "hello world";
            if (compare(s1, s2))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }


            int num1 = 3;
            int num2 = 4;
            if (compare(num1, num2))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }
            int[] n = { 1, 2, 3 };
            int[] m = { 1, 2, 3,4 };
            if (compare(n, m))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            Console.ReadKey();
        }
        static bool compare(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool compare(string a, string b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool compare(int[] a, int[] b)
        {
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == b[i])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }    
          
}
