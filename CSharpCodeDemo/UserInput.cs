using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo
{
    public class UserInput
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Calculate());
            Console.Read();
        
        }


        public static int Calculate()
        {
            Console.WriteLine("Plz enter first number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Plz enter second number");
            string number2 = Console.ReadLine();

            int number3 = int.Parse(number1);
            int number4 = int.Parse(number2);

            int result = number3 + number4;
            return result;
        }
    }
}
