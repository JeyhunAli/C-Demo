using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.forLoop
{
    internal class BREAKClass1
    {
        /*
            The break statement is going to stop the loop from executing any further,
            because after all there's no point in continuing the process when 
            I've found the first value that I'm looking for. 

        the continue statement skips the rest of the loop entirely 
        and jump to the next iterartion

        the break statement stops the value and exits 


         The continuous statement is a little bit different.
        It causes the loop to skip over the rest of the statements 
        in this iteration and continue to the next iteration of the loop. 
        */
        static void Main(string[] args)
        {
            breakConcept();
        }


        static void breakConcept()
        {

            int []  values = { 1, 2, 3, 79, 87, 54, 14, 56, 43, 37, 69, 23 };
            Console.WriteLine("using break and continue  :");
            foreach (int value in values)
            {
                Console.WriteLine($"current val is: {value}");
                if(value > 1 && value > 79)
                {
                    continue;
                }
                else if(value >= 100)
                {
                    break;
                }
            }

        }

    }
}
