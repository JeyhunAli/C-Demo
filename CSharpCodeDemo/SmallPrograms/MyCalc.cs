using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.SmallPrograms
{
    /// <summary>
    /// this is smal calc class
    /// </summary>
    public class MyCalc
    {
        /// <summary>
        ///PI IS A GREAT
        /// </summary>
        public const double PI = 3.14;

        /// <summary>
        /// Checks to see if an integer is even or no
        /// </summary>
        /// <param name="num"> number to be chekced </param>
        /// <returns> True if even, false is odd</returns>
        public bool isEven(int num)
        {
            List<int> list = new List<int>();
            
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
/*
 *
 *here in this class 3 forward slash is called xml documentation 
 *as much info you add it to the class methods variables 
 *when you call that method or class specific documentation will appear as soon as hower the mause on that
 * 
 */
