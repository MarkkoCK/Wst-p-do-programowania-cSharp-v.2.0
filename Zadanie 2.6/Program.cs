using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 4;
            x = (y -= 2); //y = y -2 / y = 4-2 / y=2
            Console.WriteLine(x);
            x = y++; // x=2 ++ wykonuje się po przywisaniu wartości do x, dlatego x=2 a na y jest wykonywanna inkrementacja y=3
            x = y--; // x=3 -- wykonuje się po przywisaniu wartości y do x dopiero potem y--
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
