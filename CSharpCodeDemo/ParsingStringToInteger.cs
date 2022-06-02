using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo
{
    public class ParsingStringToInteger
    {
        public static void Main(string[] args)
        {
            //parsing means create int out of string
            string s = "10";
            string s2 = "20";

            string ss = "10";
            string sd = "20";

            int num1 = Convert.ToInt32(s);
            int num2 = Convert.ToInt32(s2);

            int num3 = Int32.Parse(ss);
            int num4 = Int32.Parse(sd);

            int result = num1 + num2; 
            Console.WriteLine("result is " +result);

            int result2 = num3 - num4;
            Console.WriteLine("result2 is " + result2);



            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float mynewfloat = float.Parse(stringForFloat);
            int mynewInt = Convert.ToInt32(stringForInt);
            Console.WriteLine("mynewfloat is " + mynewfloat + " mynewInt is " + mynewInt);
        }
    }
}
