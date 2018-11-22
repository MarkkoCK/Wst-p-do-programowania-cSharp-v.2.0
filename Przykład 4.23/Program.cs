using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przykład_4._23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            int[] b = new int[10];
            Array.Copy(a, 2, b, 3, 5);
            foreach (int x in b)
            {
                Console.Write("{0}, ", x);
            }
            Console.ReadKey();
        }
    }
}
