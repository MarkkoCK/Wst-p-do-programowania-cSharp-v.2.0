using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._21
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
            foreach (int[] podtablica in tab)
            {
                foreach (int x in podtablica)
                {
                    Console.Write("{0,2}", x);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
