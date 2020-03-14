/**
 * Övningsuppgifter1 - uppgift 2
 * Räkna ut produkten av följande tal med hjälp av ett C#- program:
 *		15,45 * 4,563
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppg2
{
    class Program
    {
        static void Main(string[] args)
        {
            double tal1 = 15.45;
            double tal2 = 4.563;

            //Två fasta positioner för decimaler
            Console.WriteLine("Produkten av {0} och {1} = {2:0.00}", tal1, tal2, tal1 * tal2);
        }
    }
}
