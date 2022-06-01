using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.VarFolder
{
    public class VarClass1
    {
        //we can declare multiple variables at once 

        static int num1, num2, num3;

        public static void sum()
        {
            var classVar = new VarClass1();
            num1 = 1;
            num2 = 2;
            num3 = 3;

            Console.WriteLine(num1 + num2);

        }

    }

    public class VarClass2
    {
        //we can declare multiple variables at once 

        static int num1, num2, num3;

        public static void sum()
        {
            var classVar = new VarClass1();
            num1 = 1;
            num2 = 2;
            num3 = 3;

            Console.WriteLine(num1 + num2);

        }

    }
}
