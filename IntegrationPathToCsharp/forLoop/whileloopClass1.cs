using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.forLoop
{
    /// <summary>
    /// about while loop
    /// </summary>
    public class whileloopClass1
    {
        //there are going to be times when you want a loop to just keep 
        //running until a certain condition is met.    and this is while loop

        static void Main(string[] args)
        {
            //testwhileLoop();
            testDOwhileLoop();


        }


         static void testwhileLoop()
         {
            string inputstring = "";

            Console.WriteLine("please enter a word ");

            while (inputstring != "exit")
            {
                inputstring = Console.ReadLine();
                Console.WriteLine("you entered : {0}", inputstring);
            }
         }

        static void testDOwhileLoop()
        {
            string inputstring = "";


            do
            {
                Console.WriteLine("please enter a word ");
                inputstring = Console.ReadLine();
                Console.WriteLine("you entered " + inputstring);
            }
             

            while (inputstring != "exit");
            {
                
            }
        }
    }
}
