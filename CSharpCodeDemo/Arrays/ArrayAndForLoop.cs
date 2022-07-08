using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.Arrays
{
    public class ArrayAndForLoop
    {
        static void Main(string[] args)
        {
            int [] num = new int[10];

            for(int i = 0; i < num.Length; i++)
            {
                //assigning the value of its index to the value itself.
                // for instance So at index zero value will be zero.
                //At index one, value will be one.  
                //output 
                //Element at 0 = 0
                //Element at 1 = 1
                //Element at 2 = 2
                //Element at 3 = 3

                num[i] = i + 10;
            }

            for (int j = 0; j < num.Length; j++)
            {
                //getting the values out of my array and that will be equal to one.
                //here Element at {0} -> index        {1}-> actual value 
                Console.WriteLine("Element at {0} = {1}", j, num[j]);
            }

            int counter = 0;
            foreach (int k in num)
            {
                Console.WriteLine("Element at {0} = {1}", counter, k);
            }
            Console.ReadKey();

            
        }
    }
}

