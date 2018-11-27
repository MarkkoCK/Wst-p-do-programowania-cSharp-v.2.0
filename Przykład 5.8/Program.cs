using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_5._8
{
    class Program
    {
        static int[] Liczby(int rozmiar)
        {
            int[] tab = new int[rozmiar];
            for (int i = 0; i < rozmiar; i++)
            {
                tab[i] = i;
            }
            return (tab); // zwraca tablicę
        }
        static void Main(string[] args)
        {
            int[] tab1 = Liczby(5); // wywołanie metody
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write(tab1[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
