using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._28
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Ala ma kota";
            foreach (char litera in tekst)
                Console.WriteLine(litera);
            Console.ReadKey();
        }
    }
}
