using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo
{
    internal class User_Input
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("What is your name ");
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            String name = Console.ReadLine();
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            Console.WriteLine("What is your age ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("you are " + age + " years old") ;



        }
    }
}
