using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitukset_Osa4
{  

    public class Mammal
    {
        /// <summary>
        /// Mammal name
        /// </summary>
        private string name;

        /// <summary>
        /// Mammal sleepingTime
        /// </summary>
        private float sleepingTime;

        /// <summary>
        /// Public method for mammal name.
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Public method for getting and setting mammal sleepingTime.
        /// </summary>
        public float SleepingTime
        {
            get { return sleepingTime; }
            set { sleepingTime = value; }
        }


        /// <summary>
        /// Constructor for Mammal name and sleepingTime
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sleepingTime"></param>
        public Mammal(string name, float sleepingTime)
        {
            this.name = name;
            this.sleepingTime = sleepingTime;
        }

        /// <summary>
        /// Eat Mammal
        /// </summary>
        public virtual string Eat()
        {
            return "Mammal is eating";
        }

        /// <summary>
        /// Sleep Mammal
        /// </summary>
        public void Sleep()
        {

        }
    }
}
