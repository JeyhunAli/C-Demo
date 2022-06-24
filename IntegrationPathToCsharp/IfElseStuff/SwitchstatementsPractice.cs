using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.IfElseStuff
{
    /// <summary>
    /// 
    /// practice switch case
    /// </summary>
    public class SwitchstatementsPractice
    {
        static void Main(string[] args)
        {

            int TheVal = 43;
            //TODO: TheVal SWITCH STATEMENTS

            switch (TheVal)
            {
                case 50:
                    Console.WriteLine("the val is 50");
                    break;
                case 59:
                    Console.WriteLine("the val is large than 50 "+ TheVal);
                    break;
                case 40:
                case 43:
                case 42:
                    Console.WriteLine("the val between 40 - 43  and entered value is: " + TheVal);
                    break;
                    default:
                    Console.WriteLine("the val something else");
                    break ;
            }
        }

    }
}
