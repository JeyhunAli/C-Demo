namespace CSharpCodeDemo.Loop
{
    class LoopIfElseProgram
    {
        public static decimal average = 0;
        public static string errorMessage = "";
        public static void Main(string[] args)
        {
            string enteredScore = "0";
            int scores = 0;
            int counter = 0;
            int newScore = 0;

            while (enteredScore != "-1")
            {
                Console.WriteLine("Last number entered was {0}, with a combined total of {1}", newScore, scores);
                Console.WriteLine("Please enter a score between 0 and 20 or type 'Done' to get average score");
                enteredScore = Console.ReadLine();
                bool numberEntered = int.TryParse(enteredScore, out newScore);
                if (enteredScore == "Done")
                {
                 newScore = -1;
                }

                if (newScore == -1)
                {
                    getAverage(scores, counter);
                    if (errorMessage != "")
                {
                 Console.WriteLine(errorMessage);
                }
                    else
                    {
                        Console.WriteLine("The average of the {0} students is {1}. Press any key to exit the program", counter, average);
                    }
                    break;
                }
                else if (!numberEntered)
                {
                    Console.WriteLine("That is not a valid input. Please enter only a number between 0 and 20!");
                }
                else if (numberEntered && newScore <= 20)
                {
                    scores += newScore;
                    counter++;
                }
                else
                {
                    Console.WriteLine("That is too high a value, please enter a different value.");
                }
            }

            Console.Read();
        }
        public static void getAverage(int scores, int counter)
        {
            try
            {
                average = (decimal)scores / (decimal)counter;
            }
            catch
            {

                errorMessage = ("Cannot calculate the average of nothing. Please press any key to close the program and try again.");
            }
        }
    }
}









































