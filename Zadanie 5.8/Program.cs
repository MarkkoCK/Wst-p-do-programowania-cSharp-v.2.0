using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._8
{
    class Program
    {
        // Napisz metodę, która oblicza sumę cyfr liczby naturalnej x. W programie głównym
        // wywołaj funkcję dla x wczytanego z klawiatury.Przykładowo jeśli użytkownik wpisze 125,
        // to metoda powinna zwrócić wartość 8 (1+2+5=8).
        static void Main(string[] args)
        {
            int x, wynik;

            //pobierz wartosc od uzytkownika
            Console.WriteLine("Podaj wartosc x");
            x = int.Parse(Console.ReadLine());

            //oblicz sume cyfr danej liczby calkowitej
            wynik = 0;
            while (x != 0)
            {
                wynik += x % 10;
                x /= 10;
            }

            //podaj wynik
            Console.WriteLine("suma cyfr podanej liczby wynosi " + wynik);

            Console.Read();

        }
    }
}
