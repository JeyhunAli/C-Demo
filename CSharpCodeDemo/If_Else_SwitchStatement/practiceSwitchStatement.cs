using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.If_Else_SwitchStatement
{
    public class practiceSwitchStatement
    {
        static void Main(string[] args)
        {

            switch1(19);
        }
        public static void switch1(int age)
        {
            switch (age)
            {
                case 15:
                     Console.WriteLine("Too Young to party in the club!");
                     break;
                case 21:
                    Console.WriteLine("can party in the club!");
                    break;

                    default:
                    Console.WriteLine("then how old are you");
                    break ;

            }
            Console.Read();
        }
    }
}
