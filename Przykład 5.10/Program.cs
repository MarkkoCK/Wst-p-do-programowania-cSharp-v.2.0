using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_5._10
{
    class Program
    {
        static int Dodaj(int x, int y = 0)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Dodaj(1)); // wyświetli się 1
            Console.WriteLine(Dodaj(1, 5)); // wyświetli się 6
            Console.ReadKey();
        }
    }
}
