
//What is a rudimentary knowledge?
//Image result for rudimentary understanding
//adjective. Rudimentary knowledge includes only the simplest
//and most basic facts. 
//[formal] He had only a rudimentary knowledge of French. 
//Synonyms: basic, fundamental, elementary, early More Synonyms of rudimentary

namespace CSharpCodeDemo
{
    public class VariablesPractice1
    {

        //we can declare multiple variables at once 

        static int num1, num2, num3;

        public static void Main(String[] args)
        {
            sum();
            var();
            longVar();

        }

        public static void sum()
        {
            var classVar = new VariablesPractice1();
            num1 = 1;
            num2 = 2;
            num3 = 3;

            Console.WriteLine(num1 + num2 - num3);
            Console.WriteLine("great");



        }

        public static void var()
        {
            double d1 = 3.3878;
            double d2 = 3.8682;
            Console.WriteLine(d1 / d2);

            float f1 = 4.7939f;
            float f2 = 3.99839f;
            Console.WriteLine((float)f1 / (float)f2);




        }
        public static void longVar()
        {
            long d1 = 6473388339292;
            long d2 = 87837939382002;
            long d3 = 1l;

            Console.WriteLine(d1+d2+d3);




        }
        public static void longVarString()
        {
            /// adding comment
            /// this is long data type range -2 billion 2
            long d1 = 6473388339292;
            long d2 = 87837939382002;
            long d3 = 1l;

            Console.WriteLine(d1 + d2 + d3);




        }
    }
}