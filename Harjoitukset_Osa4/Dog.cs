using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitukset_Osa4
{
    public class Dog : Mammal
    {
        /// <summary>
        /// Dog energyAmount
        /// </summary>
        private int energyAmount;


        /// <summary>
        /// Constructor for name
        /// </summary>
        /// <param name="name"></param>
        public Dog(string name, float sleepingTime, int energyAmount) : base(name, sleepingTime)
        {
            this.energyAmount = energyAmount;
        }

        /// <summary>
        /// Method for getting energyAmount.
        /// </summary>
        public int EnergyAmount
        {
            get { return energyAmount; }            
        }
        
        /// <summary>
        /// Public method for dog eating.
        /// </summary>
        public override string Eat()
        {
            return "Dog is eating";
        }

        /// <summary>
        /// Method for dog eat adding energyAmount
        /// </summary>
        /// <param name="energyAmount"></param>
        public void Eat(int energyAmount)
        {
            this.energyAmount += energyAmount;
        }
    }
}
