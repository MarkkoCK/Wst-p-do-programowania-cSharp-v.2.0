using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_3._24
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            do
            {
                a++;
                if (a == 5)
                    break; // przerwij pętle
                Console.WriteLine(a);
            } while (true);
            Console.ReadKey();
        }
    }
}
