using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp
{
    internal class exceptionclass
    {
        static void Main(string[] args) {
            int a = 1002;
            int b = 0;

            int result;

            try
            {
                if(a > 1000)
                {
                    throw new ArgumentOutOfRangeException(nameof(a), a+" has to be 1000 or less ");
                }

                result = a / b;
                Console.WriteLine("the result is: {0}", result);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("whoops!");
                Console.WriteLine(e.Message + "  Exception happening plz go back to your code");
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("hey sorry 1000 is the limit ");
                Console.WriteLine(e.Message + "  Exception happening plz go back to your code");
            }
            finally
            {
                Console.WriteLine("this code is always run " +
                    "because im the finally block");
            }
        }
    }
}
