using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo
{
    internal class Constants
    {
        public static void Main(String[] args)
        {
            //Constants = immutable values which are known at compile time 
            //               and do not chnage for the life of the program

            bool isPizzaTasty = true;
            Console.WriteLine(isPizzaTasty);

            const double pi = 3.14159;   // once data type declared with const we cant chage its vale
            Console.WriteLine("pi is: "+pi);




        }
    }
}
