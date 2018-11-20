using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y;
            y = x++ * 2;
            Console.WriteLine(x);
            Console.WriteLine(y);
            
            int  r=2;
            r += 3;
            Console.WriteLine("r = " + r);
            Console.ReadKey();
        }
    }
}
