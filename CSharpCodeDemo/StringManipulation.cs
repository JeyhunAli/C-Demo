namespace CSharpCodeDemo
{
    class StringManipulation
    {
        public static void Main(string[] args)
        {

            //define variables
            int age = 20;
            string name = "Jey";
            string job = "developer";

            // 1. String concatination
            Console.WriteLine("Hello my name is " + name +" and Im " + age +" years old");

            // 2. Strin formatting here we use indexing 
            Console.WriteLine("Hello my name is {0} , I am {1} years old and my job is {2} ", name, age, job);

            // 3. String interpolation
            // it uses $ sign at the start which will allow us to write our variables
            Console.WriteLine($"Hello my name is {name} , I am {age} years old and my job is {job} ");

            //its good to use with path 
            Console.WriteLine("Verbatim Strings -> @ ");
            Console.WriteLine(@"C:\User\jey\folder\CoolLife.txt");



        }
    }
}
