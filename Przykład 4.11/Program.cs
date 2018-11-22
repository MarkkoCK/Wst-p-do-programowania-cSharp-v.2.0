using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] uczestnicy = { 19, 34, 23, 54, 31 };
            foreach (int x in uczestnicy)
                Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
