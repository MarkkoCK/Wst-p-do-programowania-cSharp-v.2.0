using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._2
{
    class Program
    {
        //Napisz program wczytujący 3 liczby rzeczywiste a, b, x, a następnie wywołujący
        //metodę, która sprawdza, czy liczba x należy do przedziału obustronnie otwartego(a, b).
        //Metoda sprawdzająca ma zwrócić wartość logiczną, którą należy zinterpretować w metodzie
        //Main() z podaniem stosownego komunikatu.

        static bool ObuStronnieOtwarty(float a, float b, float x)
        {
            bool wynik;
            if (x > a & x < b)
            {
                wynik = true;
                return wynik;
            }
            return wynik = false;
            
        }

        static void Main(string[] args)
        {
            float a,  b,  x;
            Console.WriteLine("Podaj kolejno liczby:");
            Console.Write("a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("x: ");
            x = float.Parse(Console.ReadLine());

            bool wynik = ObuStronnieOtwarty(a,b,x);
            if (wynik)
            {
                Console.WriteLine("Liczba x = {0} należy do przedziełu obustronnie otawrtego",x);
            }
            else
            {
                Console.WriteLine("Liczba x = {0} nie należy do przedziełu obustronnie otawrtego", x);
            }

            Console.ReadKey();
        }
    }
}
