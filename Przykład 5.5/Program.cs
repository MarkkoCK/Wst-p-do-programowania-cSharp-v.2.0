using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_5._5
{
    class Program
    {
        static void Dodaj(out int x, out int y)
        {
            x = 2;
            y = 5;
            Console.WriteLine("Dodaj(): x={0} y={1}", x, y);
        }
        static void Main(string[] args)
        {
            int a, b; // deklaracja, brak inicjalizacji
            Dodaj(out a, out b);
            Console.WriteLine("Main(): a={0} b={1}", a, b);
            Console.ReadKey();
        }
    }
}
