using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] uczestnicy = { 19, 34, 23, 54, 31 };
            for (int i = 1; i <= uczestnicy.Length; i++)
                Console.WriteLine(uczestnicy[i - 1]);
            Console.ReadKey();
        }
    }
}
