using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo
{
    internal class Properties
    {
        static void Main(string[] args)
        {
            // Auto-Implemented properties =  shortcut when no additional logic is required in the property
            //                                you do not have to define a field for a property,
            //                                you only have to write get; and/or set; inside the property
            //                                to create auto properties just type prop and hit tab twice

            Car car = new Car("Porsche");

            Console.WriteLine(car.Model);


            StateOfUSA state = new StateOfUSA("New York");
            Console.WriteLine(state.State);

            Console.ReadKey();
        }
    }

    class Car
    {
        public String Model { get; set; }

        public Car(String model)
        {
            this.Model = model;
        }
    }

    class StateOfUSA
    {
        public string State { get; set; }

        public StateOfUSA(String state)
        {
            this.State = state;
        }
    }
}
