using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, który dodaje dwie macierze o rozmiarze 2 x 3. Elementy macierzy
            //należy umieścić w tablicach dwuwymiarowych w trakcie deklaracji. Program ma wyświetlić
            //macierz wynikową. Wskazówka: Dodawanie macierzy – macierz wynikowa C zawiera
            //elementy, które stanowią sumę elementów macierzy A i B o odpowiednich indeksach, tzn.
            //element w zerowym wierszu i zerowej kolumnie macierzy A jest dodawany do elementu o
            //tych samych indeksach macierzy B, element A[0, 1] do B[0, 1]...itd.

            int[,] tab1 = { { 1, 1, 1 }, { 2, 2, 2 } };
            int[,] tab2 = { { 3, 3, 3 }, { 4, 4, 4 } };
            int[,] tabc = new int[2, 3];

            Console.WriteLine("Ilość wierszy w tablicy = " + tab1.GetLength(0));
            Console.WriteLine("Ilość kolumn w tablicy = " + tab1.GetLength(1));

            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    tabc[i, j] = tab1[i, j] + tab2[i, j];
                    Console.Write(tabc[i,j] + ", ");
                }
            }

            Console.Read();
        }
    }
}
