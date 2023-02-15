using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesLab
{
    /// <summary>
    /// Abstract representation of an animal
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// Animal properties
        /// </summary>
        protected string name;
        protected string colour;
        protected int age;
    

        public string Name
        {
            get => name;
        }


        public string Colour
        { 
            get => colour;
        }

        public int Age
        {
            get => age;
        }

      
        public abstract void Eat();


        public Animal() { }

    }

}
