using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_7._3
{
    class Program
    {
        static int Silnia(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
                s = s * i;
            return (s);
        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 4, 6 };
            for (int i = 0; i < 3; i++) // w tej linii wstawić punkt wstrzymania
            {
                Console.WriteLine("{0}! = {1}", tab[i], Silnia(tab[i]));
            }
            Console.ReadKey();
        }
    }
}
