namespace CSharpCodeDemo.SmallPrograms
{
    public class OddOrEven
    {
        static void Main(string[] args)
        {
            OddEven(45);

        }

        public static void OddEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"the number you entered {number} is even");
            }
            else
            {
                Console.WriteLine($"the number you entered {number} is Odd");
            }
        }
    }
}
