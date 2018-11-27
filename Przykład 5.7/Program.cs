using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_5._7
{
    class Program
    {
        static void Wielkie(string[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = tab[i].ToUpper();
            }
        }
        static void Main(string[] args)
        {
            string[] tab1 = { "jeden", "dwa", "trzy" };
            Wielkie(tab1); // wywołanie metody (tablica argumentem)
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write(tab1[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
