using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3.c
{
    class Program
    {
        static void Main(string[] args)
        {
            double dlug = 80, zarobekJanka = 50, zarobekKarola = 30;
            double splata = 0;
            int dni = 0;
            do
            {
                splata += 0.2 * zarobekJanka + 0.2 * zarobekKarola;
                Console.WriteLine("Dzień = {0} Spłata = {1}", dni, splata);
                dni++;
            } while (splata <= dlug);

            Console.WriteLine("Janek i Karol spłacą dług w ciągu {0}, spłata {1}",dni, splata);
            Console.WriteLine("20% z 100zł to = " + 0.52f *100f+"zł");
            Console.ReadKey();
        }
    }
}
