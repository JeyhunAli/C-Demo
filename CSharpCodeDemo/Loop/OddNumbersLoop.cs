using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.Loop
{
    public class OddNumbersLoop
    {
        static void Main(string[] args)
        {
            //1-20 odd numbers
            for (int i = 1; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }
         
        }
    }
}
