using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._6a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int wielkoscWymiaru0 = 4;

            wyswietlTablice(tab, wielkoscWymiaru0);
            zmienWartosc(tab, wielkoscWymiaru0,1,2,0);
            wyswietlTablice(tab, wielkoscWymiaru0);

            Console.Read();
        }

        static void zmienWartosc(int[] tab, int wielkoscWymiaru0, int index1, int index2, int wartosc) {
            int index = index1 * wielkoscWymiaru0 + index2;
            tab[index] = wartosc;
        }

        static void wyswietlTablice(int[] tab, int wielkoscWymiaru0) {
            for (int i = 0; i < tab.Length; i++)
            {
                if (i % wielkoscWymiaru0 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(tab[i]);
                Console.Write(", ");
            }
            Console.WriteLine();
           
        }
    }
}
