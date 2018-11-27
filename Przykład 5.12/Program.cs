using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_5._12
{
    class Program
    {
        static int Daj(int x = 0) // argument domyślny
        {
            return x;
        }
        static int Daj()
        {
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Daj());
            Console.ReadKey();
        }
    }
}
