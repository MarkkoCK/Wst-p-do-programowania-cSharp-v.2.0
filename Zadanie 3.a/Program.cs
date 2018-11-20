using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3.a
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, który sprawdza, czy podany rok jest rokiem przestępnym. Rok
            //przestępny dzieli się bez reszty przez 4, nie dzieli się przez 100(za wyjątkiem lat podzielnych przez 400).
            int liczba = 0;
            Console.WriteLine("Podaj liczbę dodatnią: ");
            liczba = int.Parse(Console.ReadLine());
            if (liczba >= 0)
            {
                Console.WriteLine("{0} liczba jest dodatnia",liczba);
            }
            else
            {
                Console.WriteLine("{0} liczba jest ujemna",liczba);
            }
            if (liczba % 2 == 0)
            {
                Console.WriteLine("{0} liczba jest parzysta", liczba);
            }
            else
            {
                Console.WriteLine("{0} liczba jest nieparzysta", liczba);
            }
            Console.ReadKey();
        }
    }
}
