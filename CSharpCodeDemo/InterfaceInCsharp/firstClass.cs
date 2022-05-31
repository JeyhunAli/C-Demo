using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.InterfaceInCsharp
{
    class firstClass
    {
        static void Main(String[] args)
        {
            /*
             * if you want to find root of the any method or interface poiny on that and press F12
             * 
             */


            String[] PlayerArray = { "Jey", "Sahib", "Tony" };
            foreach (String Player in PlayerArray)
            {
                Console.WriteLine(Player);
                Console.WriteLine("PLayer is {0} ", Player);
            }


        }
    }
}
