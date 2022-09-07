using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationPathToCsharp.Collections
{
    internal class generatename
    {

        public static void Main(string[] args)
        {
           Console.WriteLine(GenerateName());
        }

        public static string GenerateName() => $"Name.{Guid.NewGuid().ToString("N")[..15]}";
    }
}
