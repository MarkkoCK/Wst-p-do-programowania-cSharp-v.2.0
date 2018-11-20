using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 4;
            x = (y += 3);
            Console.WriteLine("x = (y = y + 3) = " + x);
            x = ++y;
            Console.WriteLine("x = ++y = " +y);
            x = y--;
            Console.WriteLine("x = --y = " + x);
            Console.WriteLine("y = " + y);
            Console.ReadKey();
        }
    }
}
