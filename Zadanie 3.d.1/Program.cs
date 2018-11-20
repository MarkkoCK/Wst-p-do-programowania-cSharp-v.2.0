using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3.d._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l, n;
            Console.WriteLine("Podaj bok kwadratu: ");
            int a = int.Parse(Console.ReadLine());
            for (i = 1; i <= a; i++)
            {
                if (i == 1)
                {
                    for (j = 1; j <= a; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("");
                }
                else
                {
                    if (i == a)
                    {
                        for (k = 1; k < a; k++)
                        {
                            Console.Write("*");
                        }
                    }
                    else
                    {
                        for (l = 1; l <= 1; l++)
                        {
                            Console.Write("*");
                        }
                        for (n = 1; n <= a - 2; n++)
                        {
                            Console.Write(" ");
                        }
                    }
                Console.WriteLine("*");
                }
             Console.WriteLine("");
               }
            Console.ReadKey();
        }
    }
}
