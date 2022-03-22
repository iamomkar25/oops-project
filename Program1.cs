using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_program.oops
{
    internal class Program1
    {
        static void Main(string[] args)
        {

            int[] numbers = { 51, 1, 3, 4, 98 };

            // get the minimum element
            Console.WriteLine("Smallest  Element: " + numbers.Min());

            // Max() returns the largest number in array
            Console.WriteLine("Largest Element: " + numbers.Max());

            Console.ReadLine();
        }
    }
}
