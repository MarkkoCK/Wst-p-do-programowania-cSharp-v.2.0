using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._4
{
    class Program
    {
        //Napisz program, który mnoży elementy tablicy jednowymiarowej przez zadaną liczbę.
        //Mnożenie ma być wykonane w metodzie statycznej przyjmującej jako argumenty tablicę typu
        //int oraz liczbę całkowitą(mnożnik).
        //Wykonaj zadanie w dwóch wariantach:
        //  a) Wewnątrz metody tworzona jest nowa tablica wynikowa, która ma być zwrócona
        //      przez metodę.
        //  b) Wyniki mnożenia elementów tablicy mają zostać umieszczone w tablicy będącej
        //      argumentem metody(w tym wariancie metoda ma niczego nie zwracać).
        //Przykładowo dla tablicy o elementach {1,4,6,8,2} oraz mnożniku 2 program powinien
        //wyświetlić tablicę {2,8,12,16,4}.

        static void Policz(ref int[] tab, int ile)
        {
            int[] tab2 = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                tab2[i] = tab[i] * ile;
            }
            tab = tab2;
        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4, 5 };
            Policz(ref tab, 2);
            foreach  (int item in tab)
            {
                Console.Write(item + ", ");
            }

            Console.Read();
        }
    }
}
