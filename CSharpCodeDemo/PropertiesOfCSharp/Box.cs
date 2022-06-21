using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.PropertiesOfCSharp
{
    /*
            I just want to calculate the volume of the box based on its length, its height and
            its with.
            All right, so let's just create those variables and I'm going to make them public for now.
            So now, generally, what we do with these setters and getters is that we don't give access directly

            to the variable, to the member variable, but we only give access to a method which then can adjust

            the variable and we can ourselves decide how we pass this value.

            in order to access private var we can have proprty of that class var
            even if class var declared with private and have value for example private int length = 9;
            after having  public void setLength(int length) proprtyy 
            generally, what we do with these setters and getters is that we don't give access directly
            to the variable, to the member variable, but we only give access to a method which then can adjust
            the variable and we can ourselves decide how we pass this value.
            
            
     */
    public class Box
    {
        //class variables
        private int length = 9;
        private int height;
        private int width;
        private int volume;

        public void setLength(int length)
        {
            if (length <= 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }

        public int getLength(int length)
        {
            return this.length;
        }

        public void setheight(int height)
        {
          
            this.height = height;
        }
        public int getheight(int height)
        {
            return this.height;
        }

        public int getwidth(int width)
        {
            return this.width;
        }

        public int getvolume(int volume)
        {
            return this.length * this.height* this.width;
        }
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
            box.getLength(6);
            box.getheight(8);
            box.getwidth(5);

            Console.WriteLine("volume is : " +box.getvolume(5));

            box.setLength(0);
            Console.WriteLine("get value of length "+box.getLength(0));

            box.DisplayInfo();

        }

    }
}
