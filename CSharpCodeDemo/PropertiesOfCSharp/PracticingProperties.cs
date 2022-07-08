using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.PropertiesOfCSharp
{
    public class PracticingProperties
    {
        /*
         *  Well, this is a code that is just understood by C Sharp and it even was created for us automatically
            with our ID, right.
            Just says get semicolon set, semicolon.
            So this just means that it's just going to be a default getter and default setter, which just means
            if you want to access with, you can just access it by using the with variable this property.
            And if you want to set it, you can also just use it.

        Code here is really just the same thing as this one, and internally it's also what happens once you
        compile the code so the compiler does that automatically.
        For us, it just says, OK, if you have this line of code, I'm going to totally treat it as if it
        was this code that you have here, only that it's a lot shorter and it's a lot easier to create this

         */


        public int width = 10;
        private int volume;
        private int height;
        private int lenght;



        /*
         *      why would you need this approach?
                Well, they're just used when you have no additional logic required in the property accessors so.
                and the property definitions then u can use this approach
         */
        public int MyProperty { get; set; }  //1st way of declaring property

        public int MyProperty2               //2nd way of declaring property
        {
            get
            {
                return MyProperty;
            }

            set
            {
                MyProperty = value;
            }
         }
    
        public int Width
        {
            get
            {
                return this.width;
            }

            set
            {
                MyProperty = value;
            }
        }

        public int Volume
        {
            get
            {
                return this.height * this.lenght * this.width;
            }

            //here we dont actually need to set just returning ultiplacation of all the class/member var
            //set
            //{
            //    volume = value;
            //}
        }

     


        public class testProperty
        {
            static void Main(string[] args)
            {
                var propertiExplain = new PracticingProperties();
                int test = propertiExplain.MyProperty = 10;
                Console.WriteLine("my property value is: " +test);


                int test2 = propertiExplain.MyProperty2 = 20;
                Console.WriteLine("my property2 value is: " + test2);

            }
        }

     
    }
}
