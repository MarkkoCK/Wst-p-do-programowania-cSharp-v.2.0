using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._6
{
    class Program
    {
        //Uzupełnij program z zadania 5.4 (dowolny wariant) o metodę przeładowaną
        //przyjmującą tablicę typu string oraz mnożnik typu int. W tym przypadku metoda ma powielać
        //łańcuch znaków(konkatenować tyle razy, ile wynika z mnożnika). Przykładowo dla tablicy o
        //elementach {"ala", "kot", "dom"}
        //    oraz mnożniku 2 program powinien wyświetlić tablicę
        //    {"alaala", "kotkot", "domdom"}.


        static void Main(string[] args)
        {
            int ile;
            Console.Write("Podaj mnożnik: ");
            ile = int.Parse(Console.ReadLine());

            int[] tab = { 1, 2, 3, 4, 5 };
            Policz(ref tab, ile);
            foreach (int item in tab)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            string[] tabstring = { "ala", "ma", "kota" };
            Policz(ref tabstring, ile);
            foreach (string item in tabstring)
            {
                Console.Write(item + ", ");
            }
            Console.Read();
        }

        static void Policz(ref int[] tab, int ile)
        {
            int[] tab2 = new int[tab.Length];
            for (int i = 0; i < tab.Length; i++)
            {
                tab2[i] = tab[i] * ile;
            }
            tab = tab2;
        }
        static void Policz(ref string[] tab, int ile)
        {
            string[] tab2 = new string[tab.Length];
            while (ile > 0)
            {
                for (int i = 0; i < tab.Length; i++)
                {
                    tab2[i] += tab[i];
                }
                ile--;
            }
            tab = tab2;
        }


    }
}
