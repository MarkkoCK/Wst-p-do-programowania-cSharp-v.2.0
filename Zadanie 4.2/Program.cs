using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisz program kopiujący z danej tablicy liczb całkowitych tab1 do nowej tablicy tab2
            // wyłącznie wartości dodatnie. Obie tablice mają być jednowymiarowe o rozmiarze równym 10
            // (czyli 10 - elemetowe).Elementy pierwszej tablicy(tab1) należy wpisać w trakcie deklaracji
            // tej tablicy.

            int[] tab1 = new int[10] { 1, -2, 3, 4, 5, -6, 7, 8, -9, 10 };
            int[] tab2 = new int[10];
            int j = 0;
            for (int i = 0; i < tab1.Length; i++)
            {
                if (tab1[i] > 0)
                {
                    tab2[j++] = tab1[i];
                }

            }
            //Array.Copy(tab1, tab2, tab1.Length);
            
            Console.Write("tab1: ");
            foreach (int item in tab1)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            Console.Write("tab2: ");
            foreach (int item in tab2)
            {
                Console.Write(" " + item);
            }
            Console.ReadLine();
        }
    }
}
