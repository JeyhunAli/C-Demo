using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo
{
    internal class StringMethods
    {
        public static void Main(String[] args)
        {
            //introducing string methods
            String fullName = "Jeyhun ALiyev";
            String lowerFullname = fullName.ToLower();
            Console.WriteLine(lowerFullname);

            String upperFullname = fullName.ToUpper();
            Console.WriteLine(upperFullname);

            String phoneNumber = "123-156-4569";
            Console.WriteLine(phoneNumber);
            String replacedphoneNumber = phoneNumber.Replace("-", "/");
            Console.WriteLine(replacedphoneNumber);

            int lengthoffullname = fullName.Length;
            Console.WriteLine(lengthoffullname);


            String fullname = fullName.Substring(0, lengthoffullname);
            Console.WriteLine(fullname);
            String gelmisdun = fullName.Substring(0, 6);
            Console.WriteLine(gelmisdun);



        }
    }
}
