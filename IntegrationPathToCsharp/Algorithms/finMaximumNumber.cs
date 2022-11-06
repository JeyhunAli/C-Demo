using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.Algorithms
{
    public class finMaximumNumber
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(findMaximum(1, 2, 3));
            Console.WriteLine(findMaximum(8, 8, 1));
            Console.WriteLine(findMaximum(3, 2, 3));
            Console.WriteLine(findMaximum(1, 1, 9));
            Console.WriteLine(findMaximum(1, 9, 9));

            Console.WriteLine("--------------------");

            Console.WriteLine(findMaximum2(1, 2, 3));
            Console.WriteLine(findMaximum2(8, 8, 1));
            Console.WriteLine(findMaximum2(3, 2, 3));
            Console.WriteLine(findMaximum2(1, 1, 9));
            Console.WriteLine(findMaximum2(1, 9, 9));
        }

        static int findMaximum(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c || a == c)
                {
                    return a;
                }
            }

            if (b > c)
            {
                if (b > a || a == b)
                {
                    return b;
                }
            }

            return c;
        }

        static int findMaximum2(int a, int b, int c)
        {
            int max = 0;

            if(b > max)
            {
                max = b;
            }
            if(c > max)
            {
               max = c;
            }
            return max;
        }
    }
}
