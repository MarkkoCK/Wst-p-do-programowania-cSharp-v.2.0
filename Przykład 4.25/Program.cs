using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 4, 2, 6, 23, 1, 3, 7, 0 };
            Array.Sort(tab); // sortowanie tablicy
            for (int i = 0; i < tab.Length; i++)
                Console.WriteLine(tab[i]);
            Console.ReadKey();
        }
    }
}
