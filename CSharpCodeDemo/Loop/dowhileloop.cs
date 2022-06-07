using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.Loop
{
    public class dowhileloop
    {
        static void  Main(string[] args)
        {

            int lenghOfText = 0;
            String wholetext = "";

            do
            {
                Console.WriteLine("please enter the name of your best Friend");
                string nameOfFriend = Console.ReadLine();
                int currentlengh = nameOfFriend.Length;
                lenghOfText += currentlengh;
                wholetext += nameOfFriend;
            } 
            while (lenghOfText < 20);
                Console.WriteLine("Thanks that was enough! " + wholetext);
                Console.Read();
          
            /*
             * this code asking you to entyer name until lenght of names becaming less than 20 
             * then it stop asking enter name 
             * it will return thanks that was enough
             */
        }
    }
}
