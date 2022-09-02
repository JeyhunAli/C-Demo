using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.Algorithms
{
    public class reverseString
    {
        static void Main(string[] args)
        {
            // ReverseStringFunction_1();
               ReverseStringFunction_2();
        }


        //this method is reversing only one word 
        public static void ReverseStringFunction_1()
        {
            string s = "programming";
            Console.WriteLine($"string before reversed  -> {s}");
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            Console.WriteLine($"reversed string  -> {rev}");
        }

        //this method is reversing from user input
        public static void ReverseStringFunction_2()
        {
            string s, revString = "";
            Console.WriteLine("Plz Enter string: ");
            s = Console.ReadLine();
            s = s.ToLower();
            for(int i = s.Length - 1; i >= 0; i--)
            {
                revString = revString + s[i];
            }
            Console.WriteLine("Reversed String is : " + revString);
        }
    }
}
