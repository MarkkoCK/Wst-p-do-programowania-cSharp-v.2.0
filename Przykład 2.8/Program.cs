using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 5;
            x = ++y; // x=6 y=6
            x = y++; // x=6 y=7
            x = --y; // x=6 y=6
            x = y--; // x=6 y=5
            Console.WriteLine(" x = " + x + " y = " + y + " y++ " + y++);
            Console.ReadKey();
        }
    }
}
