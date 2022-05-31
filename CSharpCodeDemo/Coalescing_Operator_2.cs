using System;


namespace CSharpCodeDemo
{

    public class Person2
    {
        public string? Name { get; set; }
    }

    class Coalescing_Operator_2
    {

        static void Main(string[] args)
        {

            Person2? person = new Person2();
            
                person.Name = null;
          //    person.Name = "Jey";


            Console.WriteLine(person?.Name ?? "Person is null");

        }
    }
}
            
