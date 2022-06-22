using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.PropertiesOfCSharp
{
    //create a read only property called Front Surface, which calculates the front
    //surface based on height and length.

   

    public class propertyTask
    {

        private int height;
        private int lenght;

        public propertyTask(int height, int lenght)
        {
            this.height = height;
            this.lenght = lenght;
        }

        public int FrontSetrvice
        {
            get
            {
                return height * lenght;
            }
        }

        public void DisplayInfo()
        {
            try
            {
                Console.WriteLine("executing test");
            }
            catch(Exception)
            {
                Console.WriteLine("height is {0}, lenght is {1}", FrontSetrvice);
            }
        }
    }
    public class test23
    {
        static void Main(string[] args)
        {
            var task = new propertyTask(10,19);
            Console.WriteLine("Front service of the class is {0}", task.FrontSetrvice);
            task.DisplayInfo();

        }
    }
}
