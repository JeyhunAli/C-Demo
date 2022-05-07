using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo
{
    internal class BasicArichmetic
    {
        public static void Main(String[] args)
        {
            int friends = 10;
            friends = friends + 5; //incremets by 5
            friends += 2;          // same thing but shortcut
            friends++;             // increments by 1

            int animals = 10;
            animals = animals - 1;   //decrements by 1
            animals -= 2;            // same thing but shortcut
            animals--;               //decrements by 1

            int dogs = 10;
            dogs = dogs * 1;   //decrements by 1
            dogs *= 2;            // same thing but shortcut
            dogs++;               //decrements by 1

            Console.WriteLine("friends count is: " + friends );
            Console.WriteLine("animals count is: " + animals );
            Console.WriteLine("dogs count is: " + dogs);

            //remainder
            int laptops = 10;
            int remainder = laptops % 3;
            Console.WriteLine("remainder is: "+ remainder);
            Console.ReadKey();


            //find if number even or odd
            int y = 10;
            if(y % 2 == 0)
            {
                Console.WriteLine("Y is even");
            }
            else
            {
                Console.WriteLine("odd");
            }

        }
    }
}
