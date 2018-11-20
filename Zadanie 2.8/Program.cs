using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1); // UWAGA! z++ wykonuje się po sprawdzeniu warunku!!!!!! 
            Console.WriteLine(x); // x = True
            Console.ReadKey();
        }
    }
}
