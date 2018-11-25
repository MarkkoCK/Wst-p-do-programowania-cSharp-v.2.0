using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, który przeanalizuje dany łańcuch pod kątem wielokrotnego
            //występowania słów w tekście. Przykładowo dla zmiennej łańcuchowej o zawartości: „Kiedy
            //idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się
            //idzie – odpowiedział Puchatek” – program powinien wypisać raport o słowach powielonych
            //w tym tekście: idzie – 2 razy, po – 2 razy, się – 3 razy.

            string tekst = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, " +
                            "żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";
            // usuwamy przecinki z tekstu zamieniajac je na spacje
            string tekst2 = tekst.Replace(',' , ' ');
            //Console.WriteLine("Po trim(): " + tekst2);
            // podzieli wyrazy na tablice wyrazów na podstawie spacji
            string[] wyrazy = tekst2.Split(' ');
            foreach (string item in wyrazy)
            {
                //Console.Write("{0} ",item);
            }
            //Usuwanie duplikatów za pomocą Disticnt()
            Console.WriteLine();
            string[] wyrazy2 = wyrazy.Distinct().ToArray();
            foreach (string item in wyrazy2)
            {
                //Console.Write("{0} ",item);
            }

            // Wyszukiwanie takich samych wyrazów
            for (int i = 0; i < wyrazy2.Length; i++)
            {
                int licznik = 0;
                for (int j = 0; j < wyrazy.Length; j++)
                {
                   
                    if (string.Equals(wyrazy2[i],wyrazy[j]) == true)
                    {
                        //Console.WriteLine(wyrazy2[i] + "==" + wyrazy[j]);
                        licznik++;
                    }                   
                }
                if (licznik > 1 & wyrazy2[i]!=" ") Console.WriteLine("Słowo {0} - {1}", wyrazy2[i], licznik);
            }
            

 
            //foreach (string item in wyrazy)
            //{
            //    Console.WriteLine(item);
            //}


            Console.Read();
            //string s25 = "Urodzony dla miasta";
            //string s26 = s25.Insert(9, "by zostać programistą ");
            //Console.WriteLine(s26);
            //Console.Read();

        }
    }
}
