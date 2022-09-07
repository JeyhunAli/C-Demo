using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.forLoop
{
    public class greetings
    {
        static void Main(string[] args)
        {
            string[] friends = { "Ali", "Hasan", "Huseyn", "Ebelfezl", "Mehdi" };

            foreach (string names in friends)
            {
                Console.WriteLine("Hello my kind firends ever {0}", names);
            }
           
        }
    }
}
