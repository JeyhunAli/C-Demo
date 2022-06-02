using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo
{
    public class TryCatch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey plz enter a number");
            string userinput = Console.ReadLine();


            int n = 0;
            int m = 5;
            int result;

            try
            {
                result = m / n;
            }
            catch (Exception)
            {

                Console.WriteLine("cannot divide by zero");
            }


            try
            {
                int userInputAsint = int.Parse(userinput);
            //}
            //catch (Exception)
            //{

                Console.WriteLine("error occured plz cjheck and enter correct number type");
            }
            catch (FormatException)
            {

                Console.WriteLine("error occured plz cjheck and enter correct number type");
            }
            catch (OverflowException)
            {

                Console.WriteLine("error occured plz cjheck and enter correct number type");
            }
            catch (ArgumentNullException)
            {

                Console.WriteLine("error occured plz cjheck and enter correct number type");
            }
            finally
            {
                Console.WriteLine("this finally block will execute anyway");
            }



            Console.ReadKey();
           
        }
    }
}
