using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_5._13
{
    class Program
    {
        static int Dodaj(int x, int y) // 1) oba argumenty int
        {
            return x + y;
        }
        static int Dodaj(int x, short y) // 2) jeden int, drugi short
        {
            return -1 * (x + y); // ta wersja zwróci liczbę ujemną
        }
        static void Main(string[] args)
        {
            int a = 1, b = 5;
            short c = 1;
            Console.WriteLine(Dodaj(a, b)); // wyświetli się 6 (metoda 1)
            Console.WriteLine(Dodaj(a, c)); // wyświetli się -2 (metoda 2)
            Console.ReadKey();
        }
    }
}
