using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.Arrays
{
    public class grades
    {
        static void Main(string[] args)
        {
            //1st way of initalizing an array
            int[] gradess = new int[5];
            gradess[0] = 20;
            gradess[1] = 2;
            gradess[2] = 5;
            gradess[3] = 27;
            gradess[4] = 24;
            

            Console.WriteLine("grades at index 0: {0}", gradess[0]);
            Console.WriteLine("please enter a grade number you got to update index zero");
            string input = Console.ReadLine();
           
            gradess[0] = int.Parse(input);
            Console.WriteLine("grades at index 0: {0}", gradess[0]+ " now");
            Console.ReadKey();

            //2nd way of initalizing an array
            int[] gradesofScineceStudent_A = { 99, 89, 100, 110, 95, 105 };
            int getlength = gradesofScineceStudent_A.GetLength(0);
            Console.WriteLine(getlength);


            //3rd way of initalizing an array
            int[] gradesofScineceStudent_B = new int[]{ 99, 89, 100, 110, 95, 105, 70, 80, };
            Console.WriteLine("grades is {0}", gradesofScineceStudent_B);
        }


    }
}
