using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * TryParse a method, which allows us to convert strings into
   numerical data types.
 * TryParse often gets used when the user submits input.
 * So, for example, the user enters his name, but the data entered is a string.
 * 
 * for example we can use it lets say user entering data then we need to parse it then get the value
 * in this case inside if else 
 * we have data converted on the else part we have default value 
 * if its executed fine 
 * if not it will take default value

  So we need to convert that into a number in order to work with it.
 */

namespace CSharpCodeDemo
{
    public class tryParse
    {
        public static void Main(string[] args)
        {
            //tryParsemethod("569");
            //temeraturetest("wr34");
            temeraturetest2("5");

        }


        /// <summary>
        ///  this method is converting string to int int case converting or parsing not happening as expected
        /// </summary>   it will go tho this line Console.WriteLine(" Value entered, was no number ,0 set as temperature");
        /// <param name="tempAsStrng"></param>
        public static void temeraturetest(String tempAsStrng)
        {

                int numTemp;
                int number;
            //here tempAsStrng >userinput which is we converting to int
            // out number > is where we are going to store it for later use 
            if (int.TryParse(tempAsStrng, out number))
            {
                numTemp = number;

            }
            else
            {
                numTemp = 0;
                Console.WriteLine(" Value entered, was no number ,0 set as temperature");
            }

            if(numTemp < 20)
            {
                Console.WriteLine(" it might be cold take coat");
            }
            else if(numTemp == 20)
            {
                Console.WriteLine("its warm outside");
            }
            else if(numTemp > 30)
            {
                Console.WriteLine("its super hot ");
            }
            else
            {
                Console.WriteLine("shorts are enaugh today");
            }
        }

        public static void temeraturetest2(String tempAsStrng)
        {

            int numTemp;
            int number;
            //here tempAsStrng >userinput which is we converting to int
            // out number > is where we are going to store it for later use 
            //here  basially storing tryParse into bool 
            //and isnide if bool true then parse
            //
            //userEnteredValue || userEnteredValue==true  both equal

            bool userEnteredValue = int.TryParse(tempAsStrng, out number);

            if (userEnteredValue==true)
            {
                numTemp = number;

            }
            else
            {
                numTemp = 0;
                Console.WriteLine(" Value entered, was no number ,0 set as temperature");
            }

            if (numTemp < 20)
            {
                Console.WriteLine(" it might be cold take coat");
            }
            else if (numTemp == 20)
            {
                Console.WriteLine("its warm outside");
            }
            else if (numTemp > 30)
            {
                Console.WriteLine("its super hot ");
            }
            else
            {
                Console.WriteLine("shorts are enaugh today");
            }
        }




        public static void tryParsemethod(string numberAsString)
        {
            int parsedValue;

            bool success = int.TryParse(numberAsString, out parsedValue);
            if (success)
            {
                Console.WriteLine($"Parsing succesful - number is {parsedValue}");
            }
            else
            {
                Console.WriteLine("Parsing failed");
            }

        }
    }
}
