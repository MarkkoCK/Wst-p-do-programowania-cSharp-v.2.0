using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_5._15
{
    class Program
    {
        static int Silnia(int n)
        {
            if (n <= 1) return 1;
            else return n * Silnia(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Silnia(4));
            Console.ReadKey();
        }
    }
}
