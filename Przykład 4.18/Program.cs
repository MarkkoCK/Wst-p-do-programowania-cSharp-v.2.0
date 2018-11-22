using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab =
            {
            new int[] {1,2},
            new int[] {3,4,5,6},
            new int[] {7,8,9}
            };
            Console.WriteLine(tab[0].Length); // wypisze 2
            Console.WriteLine(tab[1].Length); // wypisze 4
            Console.WriteLine(tab[2].Length); // wypisze 3
            Console.ReadKey();
        }
    }
}
