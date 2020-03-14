/** 
 * Övningsuppgifter1 - uppgift 5
 * Skriv ett program som omvandlar från Celsiusgrader (C) till Fahrenheit (F) med formeln F=1,8C+32. 
 * Programmet skall ha följande utskrifter:
 * Ange en temperatur i Celsiusgrader: >>20 
 * 20 grader Celsius motsvarar 68 Fahrenheit
 */

using System;

namespace uppg5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange temperaturen i Celsius : ");
            double tempCelsius = Convert.ToDouble(Console.ReadLine());

//            double tempFahrenheit = tempCelsius * 9 / 5.0 + 32;
            double tempFahrenheit = (1.8 * tempCelsius) + 32;

            Console.WriteLine("{0:0.00} grader Celsius motsvarar {1:0.00} grader Fahrenheit.", tempCelsius, tempFahrenheit);
        }
    }
}
