using System;
namespace CSharpCodeDemo.SmallPrograms
{
    public class MyCalcTest
    {
        MyCalc test = new MyCalc();
        public static void Main(string[] args)
        {
            //console properties 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            var t = new MyCalc();
            bool vale = t.isEven(6);
            //console methods
            Console.OpenStandardInput();
            Console.WriteLine(vale);
            Console.WriteLine("Hey Im here ");




        }
    }
}
