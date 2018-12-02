using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = { 1, 4, 7, 9, 3, 12 };
            int i = 0;
            while (i < tab.Length)
            {
                if (tab[i] % 2 == 0)
                {
                    Console.WriteLine("{0} to liczba parzysta", tab[i]);
                    i++;
                }
                else
                    i++;
            }
            Console.ReadKey();
        }
    }
}
