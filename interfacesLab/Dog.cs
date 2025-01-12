﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesLab
{
    /// <summary>
    /// 
    /// </summary>
    internal class Dog : Animal
    {/// <summary>
    /// Overriding Eat method
    /// </summary>
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        /// <summary>
        /// Dog object constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="colour"></param>
        /// <param name="age"></param>
        public Dog(string name, string colour, int age)
        { 
            this.name = name;
            this.colour = colour;
            this.age = age;
        }

    }
}
