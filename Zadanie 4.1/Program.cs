using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, który pozwoli zapełnić n–elementową tablicę jednowymiarową liczb
            //całkowitych wartościami podanymi przez użytkownika.Na początku działania programu
            //użytkownik podaje liczbę elementów tablicy, a następnie poszczególne wartości jej
            //elementów. Po wypełnieniu całej tablicy program powinien wypisać je w oknie konsoli.

            Console.Write("Podaj ilość elementów tablicy: ");
            int iloscElementow = int.Parse(Console.ReadLine());
            int[] tablica = new int[iloscElementow];

            for (int i = 0; i < iloscElementow; i++)
            {
                Console.WriteLine("Podaj cyfrę nr {0} do tablicy: ",i);
                tablica[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Pozycje w tablicy ");
            foreach (int item in tablica)
            {
                Console.WriteLine("{0} ",item);
            }

        }
    }
}
