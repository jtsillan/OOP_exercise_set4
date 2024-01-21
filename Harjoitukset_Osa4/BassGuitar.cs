using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitukset_Osa4
{
    public class BassGuitar : Guitar
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public BassGuitar(int keyCount, string color, string manufactor, float register, string model) :base(keyCount, color, manufactor, register, model)
        {
            this.keyCount = 4;
        }

        /// <summary>
        /// Public method for BassGuitar play call.
        /// </summary>
        /// <returns></returns>
        public override string Play()
        {
            return "Playing bass guitar";
        }
    }
}
