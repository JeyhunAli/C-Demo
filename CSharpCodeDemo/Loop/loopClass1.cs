using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.Loop
{
    public class loopClass1
    {
        static void Main(string[] args)
        {

            /*
             * for loop
             * while loop (check then go specially where condition endless)
             * do while loop (do first then check )
             * foreach loop (run through array or list)
             * 
             */
            //it will loop and increase the value by 5

            int counter;
            for (counter = 0; counter <= 50; counter += 5)
            {
                Console.WriteLine(counter);
            }
            Console.WriteLine("for loop is done");
          
        }
    }
}
