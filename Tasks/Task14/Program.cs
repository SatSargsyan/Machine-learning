using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1288;
            Console.WriteLine(CountHotels(n)); 
            Console.ReadKey();
        }
        static int CountHotels(int num)
        {
            int Sum = 0;
            string st = num.ToString();
            
            for (int i = 0; i <st.Length; i++)
            {
                if (st[i] == '0'|| st[i] == '4'|| st[i] == '6'|| st[i] == '9')
                {
                    Sum++;
                }
                else
                {
                    if (st[i] == '8')
                    {
                        Sum += 2;
                    }
                }
                
            }
            return Sum;
        }
    }
}
