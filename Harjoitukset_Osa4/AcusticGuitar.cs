using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitukset_Osa4
{
    public class AcusticGuitar : Guitar
    {
        /// <summary>
        /// AcusticGuitar soundBox
        /// </summary>
        private bool soundBox = true;

        /// <summary>
        /// Get for AcusticGuitar soundBox
        /// </summary>
        /// <returns></returns>
        public bool SoundBox
        {
            get { return soundBox; }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AcusticGuitar(bool soundBox, int keyCount, string color, string manufactor, float register, string model) : base(keyCount, color, manufactor, register, model)
        {
            this.soundBox = soundBox;
        }

        /// <summary>
        /// Public method for AcusticGuitar play call.
        /// </summary>
        /// <returns></returns>
        public override string Play()
        {
            return "Playing acustic guitar";
        }
    }
}
