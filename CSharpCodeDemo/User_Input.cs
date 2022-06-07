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
           
            String name = Console.ReadLine();
           

            Console.WriteLine("What is your age ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("you are " + age + " years old") ;



        }
    }
}
