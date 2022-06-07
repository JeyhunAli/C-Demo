using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 
        Enhanced If Statements - Ternary Operator 
        Let's create a small application that takes a temperature value as input and checks 
        if the input is an integer or not.
        If the input value is not an integer value, it should print to the console "Not a valid Temperature".
        And if the input value is the valid integer then it should work as mentioned below.
        If input temperature value is <=15 it should write "it is too cold here" to the console.
        If input temperature value is >= 16 and is <=28 it should write "it is ok" to the console.
        If the input temperature value is > 28 it should write "it is hot here" to the console.
        Make sure to use ternary operators and not if statements to check for the three conditions, 
        however you can use if statement for the other conditions like to check if the entered
        value is a valid integer or not.
 * 
 * 
 * 
 * general structure of ternary operator 
 *   Condition  ? if true : is false 
 * 
 */


namespace CSharpCodeDemo.If_Else_SwitchStatement
{
    public class EnhancedIfElseProgram
    {
        static void Main(string[] args)
        {
                        /*
                         * the input value and I'm using string empty here, you
                         * could, of course, just let it be an empty string,

                           but it really opens up other opportunities to
                           work with a string when we do it like this.
                         */
            int inputTemperature = 0;
            String temperatureMessage = String.Empty;
            string inputvalue = String.Empty;

            //takes input from console
            Console.Write("Enter the current temperature: ");
            inputvalue = Console.ReadLine();

            //validate input from console
            bool validInteger = int.TryParse(inputvalue, out inputTemperature);
             
            if (validInteger)
            {
                //if is valid integer then it will check for the conditions using nested ternary operator here!
                temperatureMessage = inputTemperature <= 15 ?
                "its cold out there " :
                inputTemperature > 15 && inputTemperature <= 22 ?
                "it's warm" :
                inputTemperature > 25 ?
                "its hot outside" :
                // this emthpy string maintain the structure
                "";

                Console.WriteLine(temperatureMessage);  
             }
            else
            {
                //incase if the input value us not a valid temperature which ic converting/parsing
                Console.WriteLine("not a valid temperature");
            }

            
        }
    }
}
