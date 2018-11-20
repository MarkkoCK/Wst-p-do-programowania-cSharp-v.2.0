using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok;
            Console.WriteLine("Podaj jakiś rok: ");
            rok = int.Parse(Console.ReadLine());

            if (rok % 4 == 0 && rok % 100 != 0)
            {
                Console.WriteLine("Rok {0} jest rokiem prestępnym.",rok);
            }
            else
            {
                Console.WriteLine("Rok {0} nie jest rokiem prestępnym.", rok);
            }
            Console.ReadKey();
        }
    }
}
