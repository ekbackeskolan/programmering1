/** 
 * Övningsuppgifter1 - uppgift 6
 * Gör ett program som konverterar SEK till euro enligt följande (kurs 1€ =10.68SEK).
 */

using System;

namespace uppg6
{
    class Program
    {
        private const double KURS = 10.68;
        static void Main(string[] args)
        {
            //För att kunna visa eurosymbolen € i konsolfönstret. Koden för € = u20ac
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Ange ett belopp i Skr (SEK) : ");
            double beloppSEK = Convert.ToDouble(Console.ReadLine());

            //            double tempFahrenheit = tempCelsius * 9 / 5.0 + 32;
            double beloppEURO = beloppSEK / KURS;

            Console.WriteLine("{0:0.00} SEK motsvarar {1:0.00} EURO (\u20ac).", beloppSEK, beloppEURO);
        }
    }
}
