using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.PropertiesOfCSharp
{
    /*
     * I just want to calculate the volume of the box based on its length, its height and
       its with.
       All right, so let's just create those variables and I'm going to make them public for now.
     * 
     */
    public class Box
    {
        //class variables
        public int length;
        public int height;
        public int width;
        public int volume;

        //So, for example, I just want to calculate the volume of the box based on its length, its height and
        //its with.
        //All right, so let's just create those variables and I'm going to make them public for now.
        public void DisplayInfo()
        {
            Console.WriteLine("lenght is {0} height is {1} width is {2} so the volume is {3}",
                length, height, width, volume = length*height*width);
        }

    }

    public class ImplementBox
    {
        static void Main(string[] args)
        {

           // Box box = new Box();    //creating object 
            var box = new Box();      //creating object 
            box.length = 5;
            box.height = 5;
            box.width = 5;

            box.DisplayInfo();

        }

    }
}
