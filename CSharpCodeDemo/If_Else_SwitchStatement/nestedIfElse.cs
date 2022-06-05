using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.If_Else_Statement
{
    public class nestedIfElse
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isregistered = true;
            string username = "";
            Console.WriteLine("please enter your username");
            Console.ReadLine();

            if (isregistered)
            {
                Console.WriteLine("hi there registered user");
                if(username != "")
                {
                    Console.WriteLine("Hi there username not empthy");
                    if (username.Equals("admin")){
                        Console.WriteLine("Correct username");
                        Console.WriteLine($"Admin true{isAdmin}");
                        if (username.EndsWith("n"))
                        {
                            Console.WriteLine("correct ending");
                        }
                    }
                }
            }

            Console.Read();

         
        }
    }
}
