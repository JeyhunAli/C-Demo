using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.Algorithms
{
    internal class Move_All_Zero_to_End
    {
        public static void Main(string[] args)
        {
            movezerostoEND();
        }

        public static void movezerostoEND()
        {
            // move all the zero to end of array
            //input = {5,5,6,9,3,5,0,4,7,0,2,5,0,2,5,0}
            //output = {}

            int[] arr = { 5,0, 5, 6, 9,0, 3, 5, 0, 4, 7, 0, 2, 5, 0, 2, 5, 0 };
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != 0)
                {
                    arr[count]=arr[i];
                    count++;
                }
            }
            while(count < arr.Length)
            {
                arr[count] = 0;
                count++;
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
            
        }

    }
}
