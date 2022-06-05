using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.SmallPrograms
{
    /*
     *  Create an application with a score, highscore and a highscorePlayer.
        Create a method which has two parameters, one for the score and one 
        for the playerName.
        When ever that method is called, it should be checked if the score of
        the player is higher than the highscore, if so, "New highscore is + " score"
        and in another line "New highscore holder is " + playerName - should be written
        ONTO THE CONSOLE, IF NOT "THE OLD HIGHSCORE OF " + HIGHSCORE + " COULD NOT 
        BE BROKEN AND IS STILL HELD BY " + HIGHSCOREPLAYER.
        CONSIDER WHICH VARIABLES ARE REQUIRED GLOBALLY AND WHICH ONES LOCALLY.
* 
     */
    class ProgramScore
    {
        static int highscore = 300;
        static string highscorePlayer = "Denis";

        static void Main(string[] args)
        {
            CheckHighscore(250, "Maria");
            CheckHighscore(315, "Michael");
            CheckHighscore(350, "Denis");

            Console.Read();
        }

        public static void CheckHighscore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);

            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still "
                    + highscore + " and held by " + highscorePlayer);
            }
        }

    }
}
