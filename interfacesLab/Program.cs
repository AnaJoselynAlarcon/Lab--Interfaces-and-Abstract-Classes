using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace interfacesLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----Dog object-------
            Console.WriteLine("Dog Name: ");
            string dogName = Console.ReadLine();

            Console.WriteLine("Dog Colour: ");
            string dogColour = Console.ReadLine();

            Console.WriteLine("Dog Age: ");
            string inputDogAge = Console.ReadLine();
            int dogAge = int.Parse(inputDogAge);

            
            Dog myDog = new Dog(dogName, dogColour, dogAge);

            Console.WriteLine("Your dog's name is: " + myDog.Name);
            Console.WriteLine(",it has " + myDog.Age + "years old and is " + myDog.Colour);
            myDog.Eat();


            //-----Cat object-----
            Console.WriteLine("Cat Name: ");
            string catName = Console.ReadLine();

            Console.WriteLine("Cat Colour: ");
            string catColour = Console.ReadLine();

            Console.WriteLine("Cat Age: ");
            string inputCatAge = Console.ReadLine();
            int catAge = int.Parse(inputCatAge);


            Cat myCat = new Cat(catName, catColour, catAge);

            Console.WriteLine("Your cat's name is: " + myCat.Name);
            Console.WriteLine(",it has " + myCat.Age + "years old and is " + myCat.Colour);
            myCat.Eat();


        }
    }
}
