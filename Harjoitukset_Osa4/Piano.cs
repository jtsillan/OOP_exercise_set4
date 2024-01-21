using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitukset_Osa4
{
    public class Piano : MusicInstrument
    {
        /// <summary>
        /// Piano amount of legs
        /// </summary>
        private int legs;

        /// <summary>
        /// Piano keyCount
        /// </summary>
        private int keyCount;

        /// <summary>
        /// Piano color
        /// </summary>
        private string color;

        /// <summary>
        /// Piano manufactor
        /// </summary>
        private string manufactor;

        /// <summary>
        /// Piano register
        /// </summary>
        private float register;

        /// <summary>
        /// Default Contructor
        /// </summary>
        /// <param name="legs"></param>
        /// <param name="keyCount"></param>
        /// <param name="color"></param>
        /// <param name="manufactor"></param>
        /// <param name="register"></param>
        public Piano(int legs, int keyCount, string color, string manufactor, float register)
        {
            this.legs = legs;
            this.keyCount = keyCount;
            this.color = color;
            this.manufactor = manufactor;
            this.register = register;            
        }

        /// <summary>
        /// Method for piano legs
        /// </summary>
        /// <returns></returns>
        public int Legs()
        {
            return this.legs;
        }

        /// <summary>
        /// Method for keyCount
        /// </summary>
        /// <returns></returns>
        public int KeyCount()
        {
            return this.keyCount;
        }

        /// <summary>
        /// Piano color
        /// </summary>
        /// <returns></returns>
        public override string Color()
        {
            return this.color;
        }

        /// <summary>
        /// Piano manufactor
        /// </summary>
        /// <returns></returns>
        public override string Manufactor()
        {
            return this.manufactor;
        }

        /// <summary>
        /// Piano register
        /// </summary>
        /// <returns></returns>
        public override float Register()
        {
            return this.register;
        }

        /// <summary>
        /// Piano play
        /// </summary>
        /// <returns></returns>
        public override string Play()
        {
            return "Playing Piano";
        }
    }
}
