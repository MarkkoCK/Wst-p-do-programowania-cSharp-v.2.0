using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_6._10
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime t1 = DateTime.Now;
            Console.WriteLine("Czas początkowy t1: {0}", t1);
            int licznik = 0;
            for (int i = 0; i < int.MaxValue; i++)
                licznik++;
            Console.WriteLine("Wartość zmiennej licznik {0}", licznik);
            DateTime t2 = DateTime.Now;
            Console.WriteLine("Czas końcowy t2: {0}", t2);
            Console.WriteLine("Różnica t2-t1: {0}", t2 - t1);
            Console.WriteLine("Dziś jest {0} dzień roku", t1.DayOfYear);
            Console.ReadKey();
        }
    }
}
