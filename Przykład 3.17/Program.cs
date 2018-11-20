using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_3._17
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 0, j = -10, k = 1; i > (j + k); i--, j++, k++)
            {
                Console.WriteLine(" i = {0} j = {1} k = {2}", i, j, k);
            }
            Console.ReadKey();
        }
    }
}
