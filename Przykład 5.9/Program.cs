using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_5._9
{
    class Program
    {
        static void Wielkie(string[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = tab[i, j].ToUpper();
                }
            }
        }
        static void Main(string[] args)
        {
            string[,] tab1 = { { "jeden", "dwa", "trzy" }, { "one", "two", "three" } };
            Wielkie(tab1); // wywołanie metody (tablica argumentem)
            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    Console.Write("{0,-8}", tab1[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
