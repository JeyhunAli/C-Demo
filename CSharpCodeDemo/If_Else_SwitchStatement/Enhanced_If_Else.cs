using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.If_Else_SwitchStatement
{
    public class Enhanced_If_Else
    {
        static void Main(string[] args)
        {


            Temp4(-79);
            Temp5(200);



        }
        //1st way of writing if else 
        public static void temp1(int temp)
        {
            string stateOfMatter;
            if(temp < 0)
            {
                Console.WriteLine(stateOfMatter = "solid");
            }
            else
            {
                stateOfMatter = "liquid";
            }
            Console.WriteLine(stateOfMatter);
        }

        //2nd way of writing if else 
        public static void temp2(int temp)
        {
            string stateOfMatter;
            if (temp < 0)
            Console.WriteLine(stateOfMatter = "solid");
            else
            stateOfMatter = "liquid";
            Console.WriteLine(stateOfMatter);
        }

        //3rd way of writing if else 
        public static void Temp3(int temp)
        {
            string stateOfMatter;
            if (temp < 0) Console.WriteLine(stateOfMatter = "solid");
            else stateOfMatter = "liquid";
            Console.WriteLine("state of matter is {0}", stateOfMatter);
        }

        //Enhanced way of writing if else 
        /// <summary>
        /// state of the matter is

        ///going to be.

        ///Temperature

        /// below zero.

        ///If that's true, then do the first, if it's false to the second.
        /// </summary>
        /// <param name="temp"></param>
        public static void Temp4(int temp)
        {
            string stateOfmatter;
            // in short enhanced if else
            stateOfmatter = temp < 0 ? "Solid" : "Liguid";

            Console.WriteLine("state of matter is {0}", stateOfmatter);
        }

        public static void Temp5(int temp)
        {
            string stateOfmatter;
            // in short enhanced if else
            //if greater that 100 is gas , else if less than 0 is solid else liquid
            stateOfmatter = temp > 100 ? "Gas" : temp < 0 ? "solid" : "liquid";

            Console.WriteLine("state of matter is {0}", stateOfmatter);
        }
    }
}
