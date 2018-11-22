using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dana jest n-elementowa tablica liczb całkowitych tab1. Napisz program kopiujący
            //wartości elementów tablicy tab1 do tablicy tab2(o tym samym rozmiarze) z przesunięciem o
            //jedną pozycje. To znaczy, że element w tablicy źródłowej o indeksie 0 powinien znaleźć się w
            //tablicy docelowej pod indeksem 1, element o indeksie 1 ma być w tablicy docelowej pod
            //indeksem 2 itd.Element ostatni tablicy źródłowej ma być elementem o indeksie 0 w tablicy
            //docelowej.

            // Uwtorzenie tablicy oraz wygenerowanie 10 liczb losowych
            int[] tab1 = new int[10];
            int[] tab2 = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                tab1[i] = (int)rand.Next(1, 1000);
            }

            int licznik = 1;
            tab2[0] = tab1[tab1.Length - 1];
            for (int j = 0; j < tab1.Length; j++)
            {                
                if (j == 0)
                {
                    int licznik2 = tab1.Length - tab1.Length + 1;
                    tab2[licznik2] = tab1[j];
                }
                else if (j > 0 & j <= 8)
                {
                    tab2[licznik] = tab1[j];
                }
                else
                {
 
                }
                licznik++;
            }
            Console.WriteLine("tab1: ");
            foreach (int item in tab1)
            {
                Console.Write("{0} ",item );
            }
            Console.WriteLine("\ntab2: ");
            foreach (int item in tab2)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}
