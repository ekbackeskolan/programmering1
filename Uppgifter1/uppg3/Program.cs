/**
 * Övningsuppgifter1 - uppgift 3
 * Gör ett program som frågar efter ett antal km och sedan omvandlar dessa till meter och skriver ut detta till skärmen.
 */

using System;

namespace uppg3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange antal kilometer: ");
            double antalKilometer = Convert.ToDouble(Console.ReadLine());

            double antalMeter = antalKilometer * 1000;

            Console.WriteLine("{0} kilometer blir {1:# 000} meter!", antalKilometer, antalMeter);
        }
    }
}
