using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
                    so for loops are typically used to execute a set of statements a specific number of times.

*/

namespace IntegrationPathToCsharp.forLoop
{
    internal class forloopClass1
    {
        static void Main(string[] args)
        {

            //loopConcept();
            //loopConcept2();
            loopConcept3();
        }

        public static void loopConcept()
        {
            int myval = 10;

            for (int i = 0; i < myval; i++)
            {

                Console.WriteLine("i is currently {0}", i);

            }

        }

        public static void loopConcept2()
        {
           int [] numbers = new int[] { 1, 2, 3, 56, 67, 79, 98, 63 };

            foreach (int i in numbers)
            {
                Console.WriteLine("i is currently {0}", i);
            } 
        }

        //TODO : count the number of o char in the string
        public static void loopConcept3()
        {
            string str = "The quick brown fox jumps over the lazy dog";


            var count = 0;
            foreach (char i in str)
            {
               if(i == 'o')
                {
                    count++;
                }
            }
            Console.WriteLine("counted char O is: {0}", count);
        }
    }
}
