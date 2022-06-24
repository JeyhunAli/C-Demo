using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.Arrays
{
    public class ArrayGrades
    {
        static void Main(string[] args)
        {
            //2nd way of initalizing an array
            int[] gradesofScineceStudent_A = { 99, 89, 100, 110, 95, 105 };
            int getlength = gradesofScineceStudent_A.GetLength(0);
            Console.WriteLine(gradesofScineceStudent_A.Length); 
            Console.WriteLine(getlength);

            //3rd way of initalizing an array
            int[] gradesofScineceStudent_B = new int[] { 99, 89, 100, 110, 95, 105, 70, 80, };
            Console.WriteLine(gradesofScineceStudent_B.Length);
            Console.WriteLine("grades is {0}", gradesofScineceStudent_B.Length);



        }
    }
}
