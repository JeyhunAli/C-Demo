using System;


namespace CSharpCodeDemo
{

    public class Person
    {
        public string? Name { get; set; }
    }

    class Coalescing_Operator
    {
     
         static void Main(string[] args)
        {

            var person = new Person { Name = null };
           

            //1
            if (person.Name == null)
            {
                String name1 = person.Name = "Jey";
                Console.WriteLine(name1);
            }

            //2
            string name2 = person.Name = person.Name ?? "Jey";
            Console.WriteLine(name2);

            //3
            String name3 = person.Name ??= "Jey";
            Console.WriteLine(name3);

            /*
             * ?? and ??= operators (C# reference)
               The null-coalescing operator ?? returns the value of its left-hand operand if it isn't null;
               otherwise, it evaluates the right-hand operand and returns its result. The ?? operator 
               doesn't evaluate its right-hand operand if the left-hand operand evaluates to non-null.
               its basically looks like if else condition if left side is null use this 
               if its not null and this thime it will pick the value of whatever on the first condition 
               
             */


        }
    }
}
