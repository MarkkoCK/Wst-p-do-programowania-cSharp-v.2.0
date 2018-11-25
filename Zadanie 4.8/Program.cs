using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzupełnij poniższy kod programu o wszystkie dni tygodnia i przy użyciu pętli wyświetl
            //zawartość tablicy: w każdym wierszu dany dzień tygodnia w trzech językach(polskim,
            //angielskim, niemieckim).

            string[,] dniTygodnia;
            dniTygodnia = new string[7, 3]; // pamiętaj o zmianie rozmiaru tablicy
            dniTygodnia[0, 0] = "poniedzialek";
            dniTygodnia[1, 0] = "wtorek";
            dniTygodnia[2, 0] = "środa";
            dniTygodnia[3, 0] = "czwartek";
            dniTygodnia[4, 0] = "piątek";
            dniTygodnia[5, 0] = "sobota";
            dniTygodnia[6, 0] = "niedziela";
            dniTygodnia[0, 1] = "monday";
            dniTygodnia[1, 1] = "tuesday";
            dniTygodnia[2, 1] = "wednesday";
            dniTygodnia[3, 1] = "thursday";
            dniTygodnia[4, 1] = "friday";
            dniTygodnia[5, 1] = "saturday";
            dniTygodnia[6, 1] = "sunday";
            dniTygodnia[0, 2] = "montag";
            dniTygodnia[1, 2] = "dienstag";
            dniTygodnia[2, 2] = "mittwoch";
            dniTygodnia[3, 2] = "donnerstag";
            dniTygodnia[4, 2] = "freitag";
            dniTygodnia[5, 2] = "samstag";
            dniTygodnia[6, 2] = "sonntag";

            for (int i = 0; i < dniTygodnia.GetLength(1); i++)
            {
                switch (i)
                {
                    case 0: {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Język polski: ");
                            Console.ResetColor();
                            break;
                        }
                    case 1: {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nJęzyk angielski: ");
                            Console.ResetColor();
                            break;
                        }
                    case 2: {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nJęzyk niemiecki: ");
                            Console.ResetColor();
                            break; }
                    default:
                        break;
                }
                for (int j = 0; j < dniTygodnia.GetLength(0); j++)
                {
                    Console.WriteLine("Dzień: " + dniTygodnia[j,i]);
                
                }
            }

            Console.Read();

        }
    }
}
