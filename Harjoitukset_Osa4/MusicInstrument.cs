using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitukset_Osa4
{
    public abstract class MusicInstrument
    {
        /// <summary>
        /// MusicInstrument play
        /// </summary>
        public abstract string Play();

        /// <summary>
        /// MusicInstrument manufactor
        /// </summary>
        public abstract string Manufactor();

        /// <summary>
        /// MusicInstrument color
        /// </summary>
        public abstract string Color();

        /// <summary>
        /// MusicInstrument register
        /// </summary>
        public abstract float Register();
        
    }
}
