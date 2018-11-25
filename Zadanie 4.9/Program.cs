using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program obliczający liczbę wyrazów w łańcuchu znaków wprowadzonym przez
            //użytkownika.Należy przyjąć, że wyrazy to ciągi znaków rozdzielone spacją.

            string tekst = "wyraz1 wyraz2 wyarz3 wyraz4";
            int liczbaWyrazow = 1;
            foreach (char item in tekst)
            {
                if (item == ' ')
                {
                    liczbaWyrazow++;
                }
            }
            Console.WriteLine("Liczba wyrazów: {0}",liczbaWyrazow);
            Console.Read();
        }
    }
}
