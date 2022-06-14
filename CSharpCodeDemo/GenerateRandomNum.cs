using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo
{
    internal class GenerateRandomNum
    {
        public static void Main(String[] args)
        {
          //Random random = new Random();
            var random = new Random();
            int num = random.Next(1, 10); // range specified beteween 1, 10 
                                          // it will generate random num between 1, 10

            Console.WriteLine(num);

            int v = num + 100;
            Console.WriteLine(v);


        }
    }
}
