using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica2d = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    Console.Write("{0,3}", tablica2d[a, b]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Rozmiar: " + tablica2d.Length);
            Console.ReadKey();
        }
    }
}
