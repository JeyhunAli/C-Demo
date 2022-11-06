using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.Collections
{
    public class ArrayExample
    {
        static void Main(string[] args)
        {
            //  Arr1();
            //  Arr2();
            //  Arr3();
            //  Arr4();
                arr5();
        }

        public static void Arr1()
        {
            string[] names = new string[4];
            names[0] = "Jey";
            names[1] = "Ali";
            names[2] = "Duncan";
            names[3] = "Kot";
            Console.WriteLine(names[0]);
        }

        public static void Arr2()
        {
            string[] cars = { "Hyundai", "BMW", "Tesla" };

            //updating 2nd element
            cars[1] = "Corvette";

            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            //Console.ReadKey();
        }

        static void Arr3()
        {
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 19;
            grades[2] = 15;
            grades[3] = 18;
            grades[4] = 16;

            Console.WriteLine("grades at the index 0: {0}", grades[0]);
            Console.ReadKey();
        }

        static void Arr4()
        {
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 19;
            grades[2] = 15;
            grades[3] = 18;
            grades[4] = 16;

            Console.WriteLine("grades at the index 0: {0}", grades[0]);
            Console.ReadKey ();

            Console.WriteLine("plz enter your index ");

            string input = Console.ReadLine();
            //converting to int from string
            grades[0] = int.Parse(input);
            Console.WriteLine("grade at the index 0 is: {0}  now ", grades[0]);
        }

        static void arr5()
        {
            //another way of declaring arrays
            int[] Astudentsgrades = { 12, 45, 45, 78, 69, 36, 99, 100, 101 };
            int[] Bstudentsgrades = new int[] { 12, 45, 45, 78, 69, 36, 99, 100, 101,103, 120 };

            Console.WriteLine("the lenght of Astudentsgrades : {0} ", Astudentsgrades.Length);
            Console.WriteLine("the lenght of Bstudentsgrades : {0} ", Bstudentsgrades.Length);
        }
    }
}
