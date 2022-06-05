using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.SmallPrograms
{
    internal class Hypotenuse
    {
        public static void Main(String[] args)
        {
            //small program to find hypotenuse of right triangle 
            ReverseString("SahibMellim");
        }


        public static void ReverseString(string s)
        {
            Console.WriteLine($"before reversing string {s}");

            string reverse = "";
            for(int i = s.Length-1;  i >= 0; i--)
            {
                reverse = reverse + s[i];

            }
            Console.WriteLine($"reversed String: {reverse}");
            
        }
    }
}
