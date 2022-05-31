using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.If_Else_Statement
{
    internal class logicalOperators
    {
        public static void Main(String[] args)
        {

            // logical operators can be used to check if more than one
            // condition is true/false
            // && (and)   both condition must be true
            // || (or)    at least one condition must be true

            Console.WriteLine("what is the temperature outside: (C)");
            double temperature = Convert.ToDouble(Console.ReadLine());

            if(temperature >=10 && temperature <= 25)
            {
                Console.WriteLine("its warm outside");
            }
            if (temperature >= -50 && temperature >= 50)
            {
                Console.WriteLine("hell outside");
            }

        }
    }
}
