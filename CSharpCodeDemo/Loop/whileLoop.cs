﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

             // here in this code once asked your name if you click enter multiple time it will 
             // keep asking your name until you enter the name

namespace CSharpCodeDemo.Loop
{
    public class whileLoop
    {
        public static void Main(String[] args)
        {
            //while loop = repeats some code while some condition remains true
           
            String name = "";
            while(name == "")
            {
                Console.Write("Enter your name:  ");

                name = Console.ReadLine();

            }
            Console.WriteLine("Hello " + name);
        }
    }
}
