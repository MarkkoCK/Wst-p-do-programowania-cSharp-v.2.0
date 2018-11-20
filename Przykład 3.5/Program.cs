using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2, z = 3;
            if (x == 1 || y != 5 && z < 1) // PAMIĘTAJ że w koniunkcji && pospełnieniu pierwszego warunku drugi nie jest sprawdzany!!!!!
                Console.WriteLine("Warunek spełniony");
            else
                Console.WriteLine("Warunek niespełniony");
            Console.ReadKey();
        }
    }
}
