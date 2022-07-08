using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp
{
    public class _1Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey we are started " +
                "Hello world tradition matter ");

            // TODO: operators can be shortened: a = a + b
            int a = 10;
            int b = 20;
            //a = a + b;
            //a += b;
            Console.WriteLine(a += b);

            // null coalescing operators
            //string str = "jey";
            string str = null;
            //TODO: The ?? operator uses left operand if not null, or righ one if it is 
            // if str is null it will asign to "unknown string"
            // if not it will take actual string
            Console.WriteLine(str ?? "unknown string");   //output "unknown string";


            //TODO:  the ??= operator assigns the right operand if the left one is null
            //it will replace the code:
            //example:
            /*
            if (variable is null){
            variable = somevariable;
            }
            */
            str ??= "new string";
            Console.WriteLine(str);    //output "new string";

        }

                /**
          * <summary>
          * this function does nothing
        *  just practice
 	        *  </summary>
        */
        public void function1()
        {

        }
    }
}
