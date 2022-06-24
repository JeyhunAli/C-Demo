using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.IfElseStuff
{
    internal class Class1Decision
    {
        static void Main(string[] args)
        {
            ternaryOperator();


        }

        /// <summary>
        /// this operator same with if else statemenet
        /// </summary>
        public static void ternaryOperator()
        {
            int val = 70;

            if(val < 50)
            {
                Console.WriteLine("the val is small ");
            }
            else
            {
                Console.WriteLine("the val is large");

            }


            //now with ternary operator
            Console.WriteLine(val < 50 ? "the val is small" : "the val is large" );


            Console.ReadKey();
        }


    }
}
