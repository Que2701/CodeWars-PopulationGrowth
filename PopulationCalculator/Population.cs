using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCalculator
{
    public class Population
    {
        public static int NbYear(int population, double percent, int newInhabitants, int totalPopulation)
        {
            int years = 0;
            while (population < totalPopulation)
            {
                population += (int)(population * (percent / 100)) + newInhabitants;
                years++;
            }
            return years;
        }
    }
}
