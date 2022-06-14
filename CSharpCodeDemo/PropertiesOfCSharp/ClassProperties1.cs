using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.PropertiesOfCSharp
{
    public class ClassProperties1
    {
        static void Main(string[] args)
        {
            ClassProperties2 classs = new ClassProperties2(25, 25);
         
            Console.WriteLine("result " + classs.numbers + classs.numbers2);


        }

    }


    class ClassProperties2
    {
        public int numbers { get; set; }
        public int numbers2 { get; set; }

        public ClassProperties2(int numbers, int numbers2)
        {
            this.numbers = numbers;
            this.numbers2 = numbers2;

        }
    }
}
