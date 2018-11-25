using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_5._6
{
    class Program
    {
        static void Elementy(params int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Elementy(1, 2, 3); // 1) wywołanie dla listy argumentów
            int[] tab1 = new int[3] { 18, 26, 67 };
            Elementy(tab1); // 2) wywołanie z użyciem tablicy
            Console.ReadKey();
        }
    }
}
