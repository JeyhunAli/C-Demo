using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.forEach
{
    internal class cars
    {
        public static void  Main(string[] args)
        {
            string[] cars = { "BMW", "FORD", "HYUNDAI" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
           
        }
    }
}


//one
//downside with a for each loop is that
//it's not flexible with a standard for
//loop we can iterate forwards   --   ++   i+=2
//backwards or even skip iterations so use
//whatever loop is more appropriate for
//your situation