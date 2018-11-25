using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_5._3
{
    class Program
    {
        static void Dodaj(int a)
        {
            a++;
            Console.WriteLine("Argument z wnętrza metody: " + a);
        }
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine("Przed wywołaniem metody: " + x);
            Dodaj(x);
            Console.WriteLine("Po wywołaniu metody: " + x);
            Console.ReadKey();
        }
    }
}
