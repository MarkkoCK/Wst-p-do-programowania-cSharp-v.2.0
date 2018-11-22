using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._17
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
            Console.WriteLine(tab[0][0]); // wypisze 1
            Console.WriteLine(tab[1][2]); // wypisze 5
            Console.WriteLine(tab[2][2]); // wypisze 9
            Console.ReadKey();
        }
    }
}
