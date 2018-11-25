using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_5._1
{
    class Program
    {
        static void Odejmij(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static void Main(string[] args)
        {
            Odejmij(4, 3); // wywołanie metody
            Console.ReadKey();
        }
    }
}
