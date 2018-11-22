using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._26
{
    class Program
    {
        static void Main(string[] args)
        {// elementy tablicy 0 1 2 3 4
            string[] imiona = { "Ala", "Ola", "Ela", "Tola", "Ela" };
            Console.WriteLine(Array.IndexOf(imiona, "Ela")); // wypisze 2
            Console.WriteLine(Array.IndexOf(imiona, "Iza")); // wypisze -1
            Console.ReadKey();
        }
    }
}
