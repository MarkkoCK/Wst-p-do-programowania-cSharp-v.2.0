using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][][] tab =
            {
                new int[][]
                {
                    new int[] {1,2},
                    new int[] {3,4,5}
                }
            };
            Console.Write(tab[0][1][2]); // wypisze 5
            Console.ReadKey();
        }
    }
}
