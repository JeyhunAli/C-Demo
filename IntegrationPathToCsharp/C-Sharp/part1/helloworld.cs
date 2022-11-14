
using System;  //--->>> the directive at the top which states using system this directive enables the developer to directly reference types


namespace IntegrationPathToCsharp.C_Sharp.part1
{
    internal class helloworld
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please Enter your Name");

            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");

            Console.ReadKey();
        }
    }
}
