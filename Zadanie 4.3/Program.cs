using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisz program wyświetlający informacje o wypełnionej przez użytkownika tablicy nelementowej:
            //* wartość i numer pozycji największego elementu,
            //* wartość i numer pozycji najmniejszego elementu,
            //* średnia wartości wszystkich elementów tablicy,
            //* liczba dodatnich elementów tablicy.

            int[] tab = { 23, 44, 5, -32, 56, -76, 223, 657, 99, 67 };

            MaksymalnaLiczba(tab);
            MinimalnaLiczba(tab);
            AvrTab(tab);
            liczbaDodatnich(tab);

            Console.ReadKey();
        }

        private static void liczbaDodatnich(int[] tab)
        {
            //* liczba dodatnich elementów tablicy.

            int j = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > 0)
                {
                    j++;
                }
            }
            // Wyświetlenie ilości dodatnich elemenów tablicy które zostały przeiesione do tab2
            Console.WriteLine("liczba dodatnich elementów tablicy: {0}", j);
        }

        private static void AvrTab(int[] tab)
        {
            // średnia wartości wszystkich elementów tablicy
            double avr = tab.Average();
            Console.WriteLine("Średnia wartości wszystkich elementów tablicy: {0}", avr);
        }

        private static void MinimalnaLiczba(int[] tab)
        {
            // Minimalna liczba
            int min = tab.Min();
            int pozycjaMin = (int)Array.IndexOf(tab, min);
            Console.WriteLine("Najmniejszy element tablicy to: {0}, numer indexu pozycji w tablicy {1}", min, pozycjaMin);
        }

        private static void MaksymalnaLiczba(int[] tab)
        {
            // Maksymalna liczba
            int max = tab.Max();
            int pozycjaMax = (int)Array.IndexOf(tab, max);
            Console.WriteLine("Największy element tablicy to: {0}, numer indexu pozycji w tablicy {1}", max, pozycjaMax);
        }
    }
}
