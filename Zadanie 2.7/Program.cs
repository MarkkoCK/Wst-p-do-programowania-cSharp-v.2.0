using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 5;
            x = ++y * 2; // x= 6 * 2 / x=12
            x = y++; //x = 6 a y = 7
            x = y--; // x = 7 a y = 6
            Console.WriteLine(++y); // y=7 wykonuje się inkrementacja
        }
    }
}
