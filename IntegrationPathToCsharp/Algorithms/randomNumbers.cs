using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.Algorithms
{
    internal class randomNumbers
    {
        private readonly static Random random = new Random();
        static void Main(string[] args)
        {
            SimpleRandom();
            Console.WriteLine("----------------------------");
            SimpleRandom2();
            Console.WriteLine("----------------------------");
            SimpleRandom3();
            Console.WriteLine("----------------------------");
            SimpleRandom4();
        }

        private static void SimpleRandom()
        {
          
            for (int i = 0; i < 10; i++)
            {
                int randomNum = random.Next();
                Console.WriteLine($"random Numbers {randomNum} ");
            }
            //Console.ReadLine();
        }

        private static void SimpleRandom2()
        {
           
            int  randomNum = random.Next();
            Console.WriteLine($"random Numbers {randomNum} ");

        }

        private static void SimpleRandom3()
        {
            

            for (int i = 0; i < 10; i++)
            {
                double randomNum = random.NextDouble();
                Console.WriteLine($"random double Numbers {randomNum} ");
            }
            //Console.ReadLine();
        }

        private static void SimpleRandom4()
        {
            

            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{FirstName = "Jey"},
                new PersonModel{FirstName = "Murad"},
                new PersonModel{FirstName = "Ali"},
                new PersonModel{FirstName = "Hasan"},
                new PersonModel{FirstName = "Adam"},
                new PersonModel{FirstName = "Huseyn"}
             };

            //this line sorting order properly in alphabetically  
            //var sortedPeople = people.OrderBy(x => x.FirstName);

            //this line sorting order properly in shuffle
            var sortedPeople2 = people.OrderBy(x => random.Next());

            foreach (PersonModel p in sortedPeople2)
            {
                Console.WriteLine(p.FirstName);
            }
          
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
    }
}
