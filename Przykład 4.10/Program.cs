using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] uczestnicy = new int[] { 19, 34, 23, 54, 31 };
            int[] odwrotnie = new int[uczestnicy.Length];
            // Wpisywanie elementów do tablicy odwrotnie
            for (int i = uczestnicy.Length - 1; i >= 0; i--)
                odwrotnie[uczestnicy.Length - i - 1] = uczestnicy[i];
            // Wyświetlenie elementów tablicy odwrotnie
            for (int i = 0; i < odwrotnie.Length; i++)
                Console.WriteLine(odwrotnie[i]);
            Console.ReadKey();
        }
    }
}
