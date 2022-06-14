namespace CSharpCodeDemo.Loop
{

    public class Program
    {


        // global variables

        static int totalScore = 0;  // combined scores for working out avergage
        static int counter = 0; // counter to enable average calculation
        static int input;       // value of input after conversion from string to integer

        // Entry point of our program
        static void Main(string[] args)
        {
            while (input != -1)
            {
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input >= 0 && input <= 20)
                    if (input >= 0 && input <= 20)
                    {
                     totalScore += input;
                     counter++;
                    }
                    else if (input == -1)
                    {
                     break;
                    }
                    else
                    {
                    Console.WriteLine("Please enter a valid score between 0 and 20");
                     continue;
                    }
             }
                else
                {
                Console.WriteLine("Not a valid number");
                continue;
                }
            }
            if (counter > 0)
            {
             Console.WriteLine(CalculateAverage(totalScore, counter));
            }
            else
            {
             Console.WriteLine("No scores entered");
            }
             Console.Read();
        }



        public static float CalculateAverage(float total, float count)

        {

            return total / count;

        }

    }
}
