using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_5._14
{
    class Program
    {
        static int Dodaj(short x, int y = 0) // 1) short oraz int domyślny
        {
            return x + y;
        }
        static int Dodaj(int x) // 2) jeden argument int
        {
            return -1 * x; // ta wersja zwróci liczbę ujemną
        }
        static void Main(string[] args)
        {
            short b = 3;
            Console.WriteLine(Dodaj(b)); // wyświetli się 3 (metoda 1)
            Console.ReadKey();
        }
    }
}
