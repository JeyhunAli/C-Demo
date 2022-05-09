using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo
{
    internal class Math_Basic
    {
        public static void Main(String[] args)
        {
            double x = 3;
            double y = Math.Pow(x, 2);
            double y1 = Math.Pow(x, 3);
            Console.WriteLine(y);
            Console.WriteLine(y1);

            double xx = 5;
            double yl = Math.Pow(x, 2);
            double yy = Math.Sqrt(xx);
            Console.WriteLine(yl);
            Console.WriteLine(y);
            Console.WriteLine(yy);

            double d = 4.98;
            double e = 5;

            double a = Math.Pow(d, 2); // powering number
            Console.WriteLine(a);
            double b = Math.Sqrt(d);
            Console.WriteLine(b);
            double c = Math.Abs(d);   // absolute
            double d2 = Math.Round(e); 
            double e2 = Math.Ceiling(d);
            double a2 = Math.Floor(d);
            double b2 = Math.Max(d, e);
            double c2 = Math.Min(d, e);
            Console.WriteLine(c2);




        }
    }
}
