using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            if ((a == 1) || (a == -1))
                Console.WriteLine("Wartość bezwzględna równa 1");
            else
                Console.WriteLine("Wartość bezwzględna różna od 1");
            Console.ReadKey();
        }
    }
}
