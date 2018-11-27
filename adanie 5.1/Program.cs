using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adanie_5._1
{
    class Program
    {
        //Napisz program zawierający metodę statyczną obliczającą temperaturę w stopniach
        //Fahrenheita na temperaturę w stopniach Celsjusza.Metoda ma przyjmować jeden argument
        //(temperaturę w stopniach Fahrenheita) i zwracać temperaturę w stopniach Celsjusza.
        //Oto wzór ze ºF na ºC: [ºC]=([ºF]-32)*5/9
        //Oto wzór ze ºC na ºF: [ºF]=[ºC]*9/5+32

        static float FahrenheitaNaCelsjusz(float temperatura)
        {
            float c = (temperatura - 32) * 5 / 9;
            return c;
        }

        static void Main(string[] args)
        {
            float f;
            Console.Write("Podaj temperaturę w stopniach Fahrenheita: ");
            f = float.Parse(Console.ReadLine());

            Console.WriteLine("Temperatura w {0}F to {1:8}C", f, FahrenheitaNaCelsjusz(f));
            Console.ReadKey();

        }
    }
}
