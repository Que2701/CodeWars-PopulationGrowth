using PopulationCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationGrowthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Population.NbYear(1500000, 0.25, 1000, 2000000));

            // Allow the user to close the application
            Console.ReadLine();
        }
    }
}
