using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program pobierający od użytkownika dwie liczby całkowite. Program powinien
            //wyświetlać informację, czy druga liczba jest dzielnikiem pierwszej.

            int liczba1, liczba2;
            Console.WriteLine("Podaj liczbę 1");
            liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę 2");
            liczba2 = int.Parse(Console.ReadLine());

            if (liczba2 % liczba1 == 0)
            {
                Console.WriteLine("Liczba {0} jest dzielnikiem liczby {1}",liczba2, liczba1 + "\nliczb2 % liczba1 wynosi: " + liczba2 % liczba1);
            }
            else
            {
                Console.WriteLine("Liczba {0} nie jest dzielnikiem liczby {1}", liczba2, liczba1 + "\nliczb2 % liczba1 wynosi: " + liczba2 % liczba1);
            }
            Console.ReadKey();
        }
    }
}
