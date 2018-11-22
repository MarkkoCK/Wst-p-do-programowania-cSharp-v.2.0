using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica2d = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            foreach (int x in tablica2d)
                Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
