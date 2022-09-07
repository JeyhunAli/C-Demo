using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.forLoop
{
    internal class forLoopProgram

        //GetOdd will get an array as input and will print every odd number from it to the console;
        //GetEven will do the same for evens;

    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);


        }

        public static void GetOdd(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 != 0)
                {
                    Console.WriteLine(Array[i]);
                }
            }
        }

        public static void GetEven(int[] Array)
        {
            foreach (int value in Array)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
