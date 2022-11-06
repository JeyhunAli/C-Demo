using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.Collections
{
    internal class Birthday
    {
        public static void Main(string[] args)
        {

            string name = "Artyom Gujin";
            int age = 26;
            
            if(name == "Artyom Gujin" && age == 26)
            {
                Console.WriteLine("Happy Brithday Artyom");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("let us know when is your birthday");
            }
        }

    }
}
