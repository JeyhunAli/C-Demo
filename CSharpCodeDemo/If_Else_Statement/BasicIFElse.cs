using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.If_Else_Statement
{
    internal class BasicIFElse
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= 18 && age <=100)
            {
                Console.WriteLine("your age " + age + " and you are signed up");
            }
            else if(age <0)
            {
                Console.WriteLine("hey you haven't been born yet!");
            }
            else if(age >= 100)
            {
                Console.WriteLine("you are too old to sing up!");
            }
                
            else
            {
                Console.WriteLine("you must be 18+ to sign up!");
            }
        }
    }
}
