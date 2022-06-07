using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.Loop
{
    public class WhileLoopClass
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while(counter < 10)  //while condition satisfied it will execute
            {
                counter++;
                Console.WriteLine(counter.ToString());
            }
            Console.Read();
          
        }
    }
}
