using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._9
{
    class Program
    {
            /// <summary>
            /// Oblicza n-ty wyraz ciagu Fibonacciego rekurencyjnie
            /// </summary>
            /// <param name="n">n (pierwszy wyraz ma index 1)</param>
            /// <returns>n-ty wyraz ciagu Fibonacciego</returns>
            public static int fib(int n)
            {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return fib(n - 1) + fib(n - 2);
            }
        /// <summary>
        /// Oblicza n-ty wyraz ciagu Fibonacciego interacyjnie (z użyciem pętli)
        /// </summary>
        /// <param name="n">n (pierwszy wyraz ma index 1)</param>
        /// <returns>n-ty wyraz ciagu Fibonacciego</returns>
        public static int fib2(int n)
        {
            if ((n == 0) || (n == 1))
                return 1;

            else
            {
                int wynik = 0;
                int a = 0, b = 1;
                for (int i = 2; i <= n; i++)
                {
                    wynik = a + b;
                    a = b;
                    b = wynik;
                }
                return wynik;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            String line;
            int n;

            Console.WriteLine("Podaj, ktory wyraz ciagu Fibonacciego obliczyc");
            line = Console.ReadLine();
            n = int.Parse(line);

            Console.WriteLine(n + "-ty wyraz ciagu Fibonacciego: " + fib(n) + " Rekurencyjnie!");
            Console.WriteLine(n + "-ty wyraz ciagu Fibonacciego: " + fib2(n) + " Interacyjnie!");
            Console.Read();
        }
    }
}
