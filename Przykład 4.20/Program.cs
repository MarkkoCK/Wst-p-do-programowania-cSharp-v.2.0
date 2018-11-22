using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] tab =
             {
                new int[,] { {1,2}, {3,4} },
                new int[,] { {5,6,7}, {8,9,10} }
            };
            Console.WriteLine(tab[1][0, 2]); // wypisze 7
            Console.ReadKey();
        }
    }
}
