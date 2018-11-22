using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._33
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekstSklejony;
            string tekst1 = "Ala ma kota";
            string tekst2 = " i psa";
            tekstSklejony = string.Concat(tekst1, tekst2);
            Console.WriteLine(tekstSklejony);
            Console.ReadKey();
        }
    }
}
