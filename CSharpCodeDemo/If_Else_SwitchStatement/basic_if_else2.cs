using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.If_Else_Statement
{
    public class basic_if_else2
    {
        public static string name;
       
        public static void Main(String[] args)
        {
            
            Console.WriteLine("please enter your age");
            
             name = Console.ReadLine();
            

            if (name == null)
            {
                Console.WriteLine("hey you didnot enter your name");
            }
            if (name != null)
            {
                Console.WriteLine("hello " + name);
            }
        }
    }
}
