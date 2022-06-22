using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.PropertiesOfCSharp
/*
 *      use this property with a capital letter
         generally how you use property.
        That's a convention and special programming.
        The properties start with a capital letter.

 */
{
    public class Box2
    {

        private int lenght = 3;
        private int height;
        private int width;
        private int volume;

        //here value is the value you are applying after creating object of this class then 
        public int Height
        {
            get 
            { 
                return height;
            }
            set
            { 
                if(value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
               
            }
        }
        

    }

    public class test
    {
        static void Main(string[] args)
        {

            Box2 box = new Box2();
            int height = box.Height = 10;
            Console.WriteLine("height is " + height );
        }
      
        
    }
}
