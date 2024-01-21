using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitukset_Osa4
{
    public class Guitar : MusicInstrument
    {
        /// <summary>
        /// Guitar keyCount
        /// </summary>
        protected int keyCount;

        /// <summary>
        /// Guitar color
        /// </summary>
        protected string color;

        /// <summary>
        /// Guitar manufactor
        /// </summary>
        protected string manufactor;

        /// <summary>
        /// Guitar register
        /// </summary>
        protected float register;

        /// <summary>
        /// Guitar model.
        /// </summary>
        protected string model;


        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="keyCount"></param>
        /// <param name="color"></param>
        /// <param name="manufactor"></param>
        /// <param name="register"></param>
        /// <param name="model"></param>
        public Guitar(int keyCount, string color, string manufactor, float register, string model)
        {
            this.keyCount = keyCount;
            this.color = color;
            this.manufactor = manufactor;
            this.register = register;
            this.model = model;
        }

        /// <summary>
        /// KeyCount for Guitar
        /// </summary>
        /// <returns></returns>
        public int KeyCount()
        {
            return keyCount;
        }

        /// <summary>
        /// Color for Guitar
        /// </summary>
        /// <returns></returns>
        public override string Color()
        {
            return color;

        }

        /// <summary>
        /// Manufactor for Guitar
        /// </summary>
        /// <returns></returns>
        public override string Manufactor()
        {
            return manufactor;
        }

        /// <summary>
        /// Register for Guitar
        /// </summary>
        /// <returns></returns>
        public override float Register()
        {
            return register;
        }

        /// <summary>
        /// Play Guitar 
        /// </summary>
        /// <returns></returns>
        public override string Play()
        {
            return "Playing Guitar";
        }
    }
}
