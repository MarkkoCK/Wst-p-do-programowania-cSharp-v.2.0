using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int y, x = 1;
            y = (x > 0) ? ++x : --x;
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
