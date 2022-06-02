namespace CSharpCodeDemo
{
    class ExplicitConversion
    {
        public static void Main(String[] args)
        {
            //implicit conversion
            int num = 1234567983;
            long bignNum = num;

            float f = 13.89f;
            double mynewDoble = f;

            double myDouble = 13.73;
            int myInt;



            //explicit conversion
            //casting double to int explicitly
            myInt = (int)myDouble;
            String myfloatstring = f.ToString();


            //type conversion 
            String myString = myDouble.ToString();
            Console.WriteLine(myString);

            bool isSunShining = true;
            String mysunisshining = isSunShining.ToString();
            Console.Write("sun is shining " +mysunisshining);



            Console.WriteLine("my int after casting " + myInt);
            Console.WriteLine("my double after casting " + myDouble);
            //Console.Read();



        }
    }
}
