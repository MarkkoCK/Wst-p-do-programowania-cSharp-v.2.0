using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._3
{
    class Program
    {
        //Napisz program, który ma znaleźć współrzędne punktu po przesunięciu o dany wektor.
        //W metodzie Main() wczytaj od użytkownika współrzędne punktu A oraz zadeklaruj
        //współrzędne wektora wek[3, 2], a następnie wywołaj metodę o nazwie Przesun(), która ma
        //przesunąć punkt A o wektor wek(dodać odpowiednie współrzędne). Współrzędne punktu
        //(jako dwie zmienne typu double) mają zostać przesłane do tej metody przez referencję, a
        //współrzędne wektora(także jako dwie zmienne typu double) przez wartość.Metoda
        //Przesun() ma nic nie zwracać (void), aktualne współrzędne punktu mają być pamiętane dzięki
        //użyciu argumentów przesyłanych przez referencje. Program ma wyświetlić współrzędne
        //punktu po przesunięciu o wektor wek. Przykładowo, gdyby użytkownik podał początkowe
        //współrzędne punktu A (2, 1), to wówczas program znajdzie położenie punktu A po
        //przesunięciu w miejscu o współrzędnych(5, 3) (czyli 2+3, 1+2).

        static void Main(string[] args)
        {
            double[,] A = new double[1, 2];
            double[,] wek = new double[3, 2];
            Przesun(ref A,ref wek);
        }
        static void Przesun(ref double[,] A,ref  double[,] wek)
        {
            double[,] AA = new double[A.GetLength(0), A.GetLength(1)];
            double[,] wekk = new double[wek.GetLength(0), wek.GetLength(1)];


        }
    }
}
