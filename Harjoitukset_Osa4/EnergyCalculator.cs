using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitukset_Osa4
{
    public class EnergyCalculator
    {
        /// <summary>
        /// Static method for calculating energy
        /// </summary>
        /// <param name="meatAmount"></param>
        /// <returns></returns>
        public static int CalculateEnergy(int meatAmount)
        {
            int energy = 195 * meatAmount / 100;
            return energy;
        }
    }
}
