using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] uczestnicy = { 19, 34, 23, 54, 31 };
            Console.WriteLine("Wielkośc tablicy ma {0} elementów",uczestnicy.Length);
            Console.Write("Zawarotść Tablicy: ");
            for (int i = 0; i < uczestnicy.Length; i++)                
                Console.Write(" " + uczestnicy[i]);
            Console.ReadKey();
        }
    }
}
