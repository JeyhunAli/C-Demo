using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.forLoop
{
    public class forLoop_ForEachLoop
    {
        public static void Main(string[] args)
        {
            int[] myArray1 = { 1, 2, 3, 4,5,6,7,8 };
            for (int i = 0; i < myArray1.Length; i++)
            {
                myArray1[i] = 11 + 1;
                Console.WriteLine("numbers in for each loop" + myArray1[i]);
            }

            Console.WriteLine("");


            int[] myArray2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (int number in myArray2)
            {
                Console.WriteLine("numbers in for each loop" + myArray2);
            }
        }
    }
}
