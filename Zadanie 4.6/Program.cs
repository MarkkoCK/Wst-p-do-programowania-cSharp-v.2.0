using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisz program, który deklaruje i inicjalizuje dwuwymiarową tablicę liczb
            //rzeczywistych o rozmiarze 5 x 5.Program ma wyświetlić elementy tablicy(wiersz po
            //wierszu), a następnie wyświetlić sumę elementów znajdujących się na głównej przekątnej
            //tablicy(główna przekątna – od elementu o indeksach 0, 0 do elementu o indeksach n,n).

            int[,] tab = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };

            int suma = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i,j]);
                    Console.Write(", ");
                    if (i==j)
                    {
                        suma += tab[i, j];
                    }
                }
                Console.WriteLine("Suma przekątnych = {0}",suma);
            }
            Console.WriteLine("");
            Console.WriteLine("Suma liczb po przekątnej tablicy = {0}", suma);
            // suma wierszy
            foreach (int item in tab)
            {

            }



            Console.ReadKey();
        }
    }
}
