﻿using System;

namespace uppg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in ett tal, tack: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mata in ett tal, tack: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mata in ett tal, tack: ");
            double tal3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hejsan! Du skrev " + tal1 +", " + tal2 + ", " + tal3 );

        }
    }
}
