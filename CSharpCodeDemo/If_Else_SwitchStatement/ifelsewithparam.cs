using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodeDemo.If_Else_Statement
{
    public class ifelsewithparam
    {
        static void Main(string[] args)
        {
            Username("Jeyhun");

            AccessTrue("jey");

        }

        public static void Username(string username)
        {
            bool isAdmin = true;   
            bool isregistered = true;
            
            
            if(isregistered && username != "" && username.Equals(username) && isAdmin != false)
            {
                Console.WriteLine($"user is successfully registered with the name {username}");
            }
        }

        public static void AccessTrue(String username)
        {
            bool isAdmin = true;
            bool isregistered = true;
            if (isregistered || isAdmin && (username.Equals(username))){
            Console.WriteLine($"user is successfully registered with the name {username}");
            }
        }
    }
}
