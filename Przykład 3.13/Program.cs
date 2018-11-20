using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
                for (int j = 1; j <= 5; j++)
                    Console.WriteLine("i = {0}, j = {1}", i, j);
            Console.ReadKey();
        }
    }
}
