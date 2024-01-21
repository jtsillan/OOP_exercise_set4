using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitukset_Osa4
{
    public class ElectricGuitar : Guitar
    {
        /// <summary>
        /// ElectricGuiter power in wats.
        /// </summary>
        private float _power;

        /// <summary>
        /// Public method for getting and setting ElectricGuitar power.
        /// </summary>
        public float Power
        {
            get => _power;
            set => _power = value;
        }

        /// <summary>
        /// Default contructor
        /// </summary>
        /// <param name="power"></param>
        /// <param name="keyCount"></param>
        /// <param name="color"></param>
        /// <param name="manufactor"></param>
        /// <param name="register"></param>
        /// <param name="model"></param>
        public ElectricGuitar(float power, int keyCount, string color, string manufactor, float register, string model) : base(keyCount, color, manufactor, register, model)
        {
            _power = power;
        }

        /// <summary>
        /// Public method for ElectricGuitar play call.
        /// </summary>
        /// <returns></returns>
        public override string Play() 
        {
            return "Playing electric guitar";
        }
        
    }
}
