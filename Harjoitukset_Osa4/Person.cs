using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitukset_Osa4
{
    public class Person
    {
        /// <summary>
        /// Person name
        /// </summary>
        private string name;

        /// <summary>
        /// Person age
        /// </summary>
        private int age;

        /// <summary>
        /// Person year of birth
        /// </summary>
        private int birthYear;

        /// <summary>
        /// DateTime this year
        /// </summary>
        DateTime now = new();
        
        /// <summary>
        /// Getter method for birthYear.
        /// </summary>
        public int BirthYear
        {
            get { return birthYear; }
        }

        /// <summary>
        /// Person Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthYear"></param>
        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
            age = now.Year - birthYear;
        }
        
        /// <summary>
        /// Method for returning name
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return name;
        }

        /// <summary>
        /// Method for returning age
        /// </summary>
        /// <returns></returns>
        public string Age()
        {
            return age.ToString();
        }
    }
}
