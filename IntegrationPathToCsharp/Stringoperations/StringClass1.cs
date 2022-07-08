using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.Stringoperations
{
    internal class StringClass1
    {
        static void Main(string[] args)
        {
            // Declare some strings for the exercises
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string[] strs = { "one", "two", "three", "four" };

            // TODO: Length of a string 
            Console.WriteLine($"the length of str1 is:{str1.Length}");


            // TODO: Access individual characters
            Console.WriteLine("accessing individual char of string -> " +str2[8]);

            // TODO: iterate over a string like any other sequence of values
            foreach(char c in str3)
            {
                Console.Write($"{c}");
                if(c == 'a')
                {
                    Console.WriteLine();
                    break;
                }
            }

            // TODO: String Concatenation
            


            // TODO: Joining strings together with Join


            // TODO: String Comparison
            // Compare will perform an ordinal comparison and return:
            // < 0 : first string comes before second in sort order
            // 0 : first and second strings are same position in sort order
            // > 0 : first string comes after the second in sort order


            // TODO: Equals just returns a regular Boolean


            // TODO: String Searching

        }
    }
}
