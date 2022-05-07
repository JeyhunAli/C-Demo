using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo
{
    internal class TypeCasting
    {
        public static void Main(String[] args)
        {

            //type casting = is converting a value to a different data type
            //               useful when we accept user input (string)
            //               Different data types can do different things

            //double to int
            double a = 3.78;
            Console.WriteLine("before converting " +a);
            int b = Convert.ToInt32(a);
            Console.WriteLine("after converting " + b);

            double c = 3.03;
            Console.WriteLine("before converting " + c);
            int d = Convert.ToInt32(a);
            Console.WriteLine("after converting " + d);

            //getType method return what data type is declared value

            int e = 4;
            Console.WriteLine(e.GetType());

            double ss = 5.5;
            Console.Write(ss.GetType());

            //int to double
            int aa = 2333;
            double a1 = Convert.ToDouble(aa);
            Console.WriteLine(aa);
            Console.WriteLine(a1);
            Console.WriteLine(a1+0.1);   // this line will display the decimal point
            Console.WriteLine(a1.GetType());



            // int to String
            int i = 10;
            String s = Convert.ToString(i);
            Console.WriteLine(s.GetType());
            Console.WriteLine(s+1);// output 101 because string 

        }
    }
}
 