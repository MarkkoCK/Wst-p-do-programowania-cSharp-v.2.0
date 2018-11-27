using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._7
{
    class Program
    {
        //Napisz statyczną metodę, która oblicza wyrażenie:
        //W = (x+1) + (x+2) + (x+3) +.......+ (x+n). W metodzie Main() wywołaj funkcję dla x i n
        //(liczb naturalnych) wczytanych z klawiatury.
        static void Main(string[] args)
        {
            Console.Write("Podaj x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Oblicz(x, n));

            Console.Read();
        }

        static int Oblicz(int x, int n)
        {
            int[] tab = new int[n];
            int wynik =  0;
            for (int i = 0; i < n; i++)
            {
                tab[i] = x + (i + 1);
            }
            foreach (int item in tab)
            {
                wynik += item;
            }
            return wynik;
        }
    }
}
