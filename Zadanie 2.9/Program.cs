using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            ////a)          
            //int x = 1, y = 4, z = 2;
            //bool wynik = (x++ > 1 && y++ == 4 && z-- > 0); // false x=2 y=4 z=2 wartości y i z nie zostaną zmienione ponieważ sprawdznie warunków zakończy się na x reszta kodu nie zostaje sprawdzana ze względu na &&
            //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            ////b)
            //int x = 1, y = 4, z = 2;
            //bool wynik = (x++ > 1 & y++ == 4 && z-- > 0); // false x=2 y=5 z=2 ze wzgledu na false i && z nie zostaje dekrementowane
            //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            ////c)
            //int x = 1, y = 4, z = 2;
            //bool wynik = (x++ > 1 & y++ == 4 & z-- > 0); // x=2 y=5 z=1 falese
            //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            ////d)
            //int x = 1, y = 3, z = 4;
            //bool wynik = (x == 1 || y++ > 2 || ++z > 0); // true x=1 y=3 z=4
            //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            ////e)
            //int x = 1, y = 3, z = 4;
            //bool wynik = (x == 1 | y++ > 2 || ++z > 0);  // true x=1 y=4 z=4
            //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            ////f)
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 | ++z > 0); // true x=1 y=4 z=5
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

            Console.ReadKey();
        }
    }
}
