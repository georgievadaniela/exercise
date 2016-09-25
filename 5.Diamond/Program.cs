using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', n - i), new string('*', 5 * n - 2 * (n - i)));

                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('.', n - i), new string('.', 5 * n - 2 * (n - i) - 2));     
                }
            }
            for (int j = 0; j < 2*n+2; j++)
            {
                if (j == 0)
                {
                    Console.WriteLine(new string ('*', 5*n));
                }
                else if (j == 2*n + 1)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('.', j), new string('*', 5 * n - 2 * j - 2));

                }
                else 
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('.', j), new string('.', 5 * n - 2 * j - 2));

                }

            }
        }
    }
}
