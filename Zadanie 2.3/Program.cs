using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program, który oblicza wskaźnik masy ciała BMI.Program ma prosić
            //użytkownika o podanie wagi w kilogramach oraz wzrostu w metrach.Wzór: BMI=masa/wzrost*wzrost
            float masa, wzrost;
            Console.WriteLine("Podaj swoja wagę: ");
            masa = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój wzrost: ");
            wzrost = float.Parse(Console.ReadLine());

            float BMI = masa / (wzrost * wzrost);

            Console.WriteLine("BMI wynosi {0}",BMI);
            Console.ReadKey();

        }
    }
}
