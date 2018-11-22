using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] uczestnicy = { 19, 34, 23, 54, 31 };
            int suma = 0;
            double srednia;
            Console.Write("Wiek uczestników: ");
            // pętla for
            //for (int i = 0; i < uczestnicy.Length; i++)
            //{
            //    Console.Write("{0}, ", uczestnicy[i]);
            //    suma += uczestnicy[i];
            //}
            // to samo tylko za pomocą pętli foretch
            foreach (int x in uczestnicy)
            {
                Console.Write("{0}, ", x);
                suma += x;
            }
            srednia = (double)suma / uczestnicy.Length;
            Console.WriteLine();
            Console.WriteLine("Średnia: {0}", srednia);
            Console.ReadKey();
        }
    }
}
