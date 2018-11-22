using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaracja z inicjalizacją
            int[] tablica = { 19, 34, 23 };

            // Deklaracja bez inicjalizacji, przypisanie w
            //osobnych liniach(przykład 4.5)
            int[] tablica = new int[3];
            tablica[0] = 19;
            tablica[1] = 34;
            tablica[2] = 23;
        }
    }
}
