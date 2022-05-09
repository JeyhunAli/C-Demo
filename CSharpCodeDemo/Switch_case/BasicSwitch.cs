using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.Switch_case
{
    internal class BasicSwitch
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("what day is it Today?");
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            String day = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            switch(day)
            {

                case "Monday":
                    Console.WriteLine("you are in Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("you are in Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("you are in Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("you are in Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("you are in Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("you are in Saturday");
                    break;
                case "Sunday":
                    Console.WriteLine("you are in Sunday");
                    break;
                    default:
                    Console.WriteLine(day + " is not a day you are looking for");
                    break;
            }
        }
    }
}
