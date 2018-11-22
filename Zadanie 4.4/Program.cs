using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Napisz program, który podaje, ile jest liczb pierwszych w tablicy 100 elementowej typu
            //int.Tablicę należy wypełnić losowymi wartościami. Wskazówka: Poniższy fragment
            //programu pokazuje działanie klasy Random(która zawiera generator liczb pseudolosowych) –
            //w pętli zostanie wyświetlonych 100 liczb wybranych losowo z zakresu 1 – 999(o zakresie
            //decydują argumenty podane w wywołaniu metody

            //Random rand = new Random();
            //for (int i = 0; i < 100; i++)
            //    Console.Write("{0,8}", rand.Next(1, 1000));

            // Uwtorzenie tablicy oraz wygenerowanie 100 liczb losowych
            int[] tab = new int[100];
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                tab[i] = (int)rand.Next(1, 1000);
            }

            // Wyświetlenie liczb z tablicy na ekran
            Console.Write("Elementy losowe tablicy: ");
            foreach (int item in tab)
            {
                Console.Write("{0} ",item);
            }

            // Wyświetlanie na ekran lizb pierwszych z tablicy oraz obliczanie ile liczb pierwszych występuje w tablicy
            int licznik = 0;
            Console.WriteLine();
            Console.Write("\nLiczby pierwsze w tabeli: ");
            for (int j = 0; j < tab.Length; j++)
            {
                if (tab[j] % 2 == 0)
                {
                    Console.Write("{0} ",tab[j]);
                    licznik++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("\nWszystkich liczb pierwszych w tabeli jest: {0}",licznik);
            Console.ReadKey();
        }
    }
}
