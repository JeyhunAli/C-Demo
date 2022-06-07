using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.Loop
{
    public class practiceBreak
    {
        static void Main(string[] args)
        {
            //checkBreak();
            checkBreak2();


        }
        public static void checkBreak()
        {
            for (int i = 0; i < 10; i++)
            {
                if(i == 4)
                {
                    Console.WriteLine("here we skip number 4!");
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.Read();
        }

        public static void checkBreak2()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"This is even number {i} ------> odd Number is next!");
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
