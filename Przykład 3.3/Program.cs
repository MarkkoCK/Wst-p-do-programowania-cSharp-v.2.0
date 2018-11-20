using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 3;
            if (a < b)
                Console.WriteLine("{0} jest mniejsze od {1}", a, b);
            else
                Console.WriteLine("{0} nie jest mniejsze od {1}", a, b);
            Console.ReadKey();
        }
    }
}
