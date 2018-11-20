using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3.b
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1, liczba2;
            Console.WriteLine("Podaj pierwszą liczbę: ");
            liczba1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę: ");
            liczba2 = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Jakie liczby chcesz wybrać? \n1 - Liczby parzyste\n2 - Liczby nieparzyste");
            string menu = Console.ReadLine();
            Console.ResetColor();

            switch (menu)
            {
                case "1":
                    if (liczba1 <= liczba2)
                    {
                        Console.WriteLine("Liczby parzyste z przedziału od {0} do {1}: ", liczba1, liczba2);
                        for (int i = liczba1; i < liczba2; i++)
                        {
                            if (i % 2 == 0)
                                Console.Write(i + ", ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("liczba1 jest większa od liczb2, wykonuje drugą metodę: ");
                        Console.WriteLine("Liczby parzyste z przedziału od {0} do {1}: ", liczba2, liczba1);
                        for (int i = liczba2; i < liczba1; i++)
                        {
                            if (i % 2 == 0)
                                Console.Write(i + ", ");
                        }
                    }
                   break;
                case "2":
                    if (liczba1 <= liczba2)
                    {
                        Console.WriteLine("Liczby parzyse z przedziału od {0} do {1}: ", liczba1, liczba2);
                        for (int i = liczba1; i < liczba2; i++)
                        {
                            if (i % 2 != 0)
                                Console.Write(i + ", ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("liczba1 jest większa od liczb2, wykonuje drugą metodę: ");
                        Console.WriteLine("Liczby parzyste z przedziału od {0} do {1}: ", liczba2, liczba1);
                        for (int i = liczba2; i < liczba1; i++)
                        {
                            if (i % 2 != 0)
                                Console.Write(i + ", ");
                        }
                    }
                    break;
                default:
                    break;
            }

           
            Console.ReadKey();

            ////Sposób nr 2
            //liczba1 = (liczba1 % 2 == 0) ? liczba1 : liczba1 + 1;
            //liczba2 = (liczba2 % 2 == 0) ? liczba2 : liczba2 - 1;
            //for (int i = liczba1; i <= liczba2; i += 2)
            //{
            //    Console.Write(i + ",");
            //}
        }
    }
}
