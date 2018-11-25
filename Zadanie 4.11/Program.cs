using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program analizujący częstość występowania poszczególnych znaków w
            //łańcuchu znaków wprowadzonym przez użytkownika.Np.dla wprowadzonego tekstu
            //„abrakadabra” program powinien wyświetlić informacje: a – 5, b – 2, r – 2, k – 1, d – 1.

            string tekst = "babajaga";
            Console.WriteLine("Ilość znaków : {0}",tekst.Length);
            // liczniki ilości występowania liter
            char[] literki = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' ,'h', 'i', 'j', 'k'};
            int[] licznik = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int j = 0;
            foreach (char item in tekst)             
            {
                Console.Write(tekst.ElementAt(j) + ", ");
                char litera = tekst.ElementAt(j);
                int licznikLitera = 0;
                foreach (char item2 in literki)
                {                    
                    if (item2 == litera)
                    {
                        licznik[licznikLitera] += 1;
                    }
                    licznikLitera++;
                }
                j++;

            }
            Console.WriteLine();
            for (int i = 0; i < literki.Length; i++)
            {
                if (licznik[i] > 0)
                {
                    Console.WriteLine("Literka {0} - {1}", literki[i], licznik[i]);
                }
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
