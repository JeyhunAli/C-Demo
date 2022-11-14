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


            //declaring array
            int[] arr = { 5,0, 5, 6, 9,0, 3, 5, 0, 4, 7, 0, 2, 5, 0, 2, 5, 0 };
            //starting int count
            int count = 0;
            //looping through all the numbers in array
            for (int i = 0; i < arr.Length; i++)
            {
                //if numbers inside array not equal to zero
                if(arr[i] != 0)
                {
                    //bringing them one by one to the beggining of array by adding all to count where count initilly zero
                    arr[count]=arr[i];
                    //increasing by one
                    count++;
                }
            }
            //after finding all the numbers still zero less than array lenght
            while(count < arr.Length)
            {
               //hat ever left over add to the end of count
                arr[count] = 0;
                //increase by one 
                count++;

            }
            //loop through all the array one more time
            for (int i = 0; i < arr.Length; i++)
            {
                //print
                Console.WriteLine(arr[i]);
            }


        }

    }
}
