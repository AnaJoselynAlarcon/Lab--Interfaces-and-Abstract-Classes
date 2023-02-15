using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesLab
{
    internal class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }

        /// <summary>
        /// Cat object constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="colour"></param>
        /// <param name="age"></param>
        public Cat(string name, string colour, int age)
        {
            this.name = name;
            this.colour = colour;
            this.age = age;
        }
    }
}
