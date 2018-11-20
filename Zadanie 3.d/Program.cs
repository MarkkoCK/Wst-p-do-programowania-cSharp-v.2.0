using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3.d
{
    class Program
    {
        static void Main(string[] args)
        {
            int iloscGwiazdek;
            Console.WriteLine("Podaj ilość gwiazdek: ");
            iloscGwiazdek = int.Parse(Console.ReadLine());
            for (int i = 0; i <= iloscGwiazdek; i++)
            {
                
                for (int j = 0; j <= iloscGwiazdek; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
