using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1 = 5, p2 = p1;
            Console.WriteLine("p1 = {0}", p1);
            Console.WriteLine("p2 = {0}", p2);
            p1 = 8;
            Console.WriteLine();
            Console.WriteLine("Wartości po zmianie p1");
            Console.WriteLine("p1 = {0}", p1);
            Console.WriteLine("p2 = {0}", p2);
            Console.ReadKey();
        }
    }
}
