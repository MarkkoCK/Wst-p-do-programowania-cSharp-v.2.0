using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.8 Metody przeładowane
//Nazwa metody wraz z listą argumentów tworzy tzw.sygnaturę.W uproszczony sposób
//możemy przedstawić sygnaturę dla przykładowej metody o deklaracji int MojaMetoda(int x,
//double y) w postaci MojaMetoda_int_double. Jak widać, zwracany typ nie ma wpływu na
//postać sygnatury. W danej klasie zdefiniowane metody muszą się różnić sygnaturą, ale mogą
//mieć taką samą nazwę. Metody, które mają tę samą nazwę i różnią się listą argumentów
//nazywane są metodami przeładowanymi lub przeciążonymi (ang.overloaded).
//Przeładowanie metod dotyczy wszystkich rodzajów metod, nie tylko statycznych, na których
//(obecnie) testujemy działanie metod
namespace Przykład_5._11
{
    class Program
    {
        static string OpiszTyp()
        {
            return "Metoda bez argumentów";
        }
        static string OpiszTyp(int x)
        {
            return "Liczba całkowita";
        }
        static string OpiszTyp(string x)
        {
            return "Łańcuch znaków";
        }
        static string OpiszTyp(double x, int y)
        {
            return "Liczba double i liczba całkowita";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(OpiszTyp());
            Console.WriteLine(OpiszTyp(10));
            Console.WriteLine(OpiszTyp("Apollo 10"));
            Console.WriteLine(OpiszTyp(100.45, 10));
            Console.ReadKey();
        }
    }
}
