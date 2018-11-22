using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] uczestnicy = new int[]{ 12, 34, 23, 54, 31 };
            int max = uczestnicy[0]; // tymczasowe maksimum
            for (int i = 1; i < uczestnicy.Length; i++)
            {
                if (uczestnicy[i] > max)
                {
                    max = uczestnicy[i];
                }
            }
            Console.WriteLine("Najstarszy uczestnik ma {0} lat(a)", max);
            Console.ReadKey();
        }
    }
}
