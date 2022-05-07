using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo
{
    internal class Comments
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("Hello, World!");
            Console.WriteLine("learning bro");
            Console.WriteLine("add comment");
            //comment
            /*
             * this 
             * is
             * a 
             * multline
             * comment
             */

            Console.WriteLine("\t Jey"); //this will add tab
            Console.WriteLine("Aliyev\bJey"); // this will ad backspace
            Console.ReadKey(); // this line will prevent ending the program until u click keyboard
                               // also its not showing gibberish on console
        }
    }

}