/** 
 * Övningsuppgifter1 - uppgift 4
 * Gör ett program som frågar efter din ålder och sedan talar om för dig hur många år du har kvar till din
 * 50-årsdag samt till din pensionsdag.
 */

using System;

namespace uppg4
{
    class Program
    {
        private const double PENSION = 67.0;

        static void Main(string[] args)
        {
            
            Console.Write("Hur gammal är du? : ");
            double age = Convert.ToDouble(Console.ReadLine());

            double yearsTo50 = 50 - age;
            double yearsToPension = PENSION - age;

            Console.WriteLine("Du är {0} år och du har {1} år kvar till din 50-års dag.", age, yearsTo50);
            Console.WriteLine("Det är dessutom {0} år kvar tills du är pensionär!", yearsToPension);
        }
    }
}
