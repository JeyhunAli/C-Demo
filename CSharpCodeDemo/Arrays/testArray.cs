using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.Arrays
{

    //this code work in java not in c#
    internal class testArray
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };


            foreach (int num in array)
            {
                array[num] = num + 10;
                Console.WriteLine("Element at" + num + "=" + array[num]);
            }
            Console.ReadKey();
        }
    }

    public class testArray2
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {

                num[i] = i + 10;
            }

            int counter = 0;
            foreach (int k in num)
            {
                Console.WriteLine("Element at {0} = {1}", counter, k);
                counter++;
            }
            Console.ReadKey();
        }


    }

    public class testArray3
    {
        //So that one's pretty simple creating Array with five of your best friends.
        // then create a for each loop, which greets all of them.
        static void Main(string[] args)
        {

            string[] myFriends = { "Sahib", "Jeyhun", "Ali", "Ahmadov", "Emil" };

            foreach (string name in myFriends)
            {
                Console.WriteLine("Hi there {0}, my Friends ", name );
            }
            Console.ReadKey(true);
        }

	
    }
}
