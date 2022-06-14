using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.Loop
{
    public class whileLoopProgram
    {
        static void Main(string[] args)
        {

            int counter = 0; 
            String enteredText = "";
            while (enteredText.Equals(""))
            {
                Console.WriteLine("plz press enter to increase amount by one and anything else " +
                    "enter if you want to finish the counting program");
                enteredText = Console.ReadLine();
                counter++;
                Console.WriteLine($"current people count is {counter}");
            }
            Console.WriteLine("{0} people are inside the bus. plz press enter to close the program", counter);
            Console.Read();
        }
    }
}
