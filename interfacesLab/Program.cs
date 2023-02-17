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
            Console.Write("Dog Name: ");
            string dogName = Console.ReadLine();

            Console.Write("Dog Colour: ");
            string dogColour = Console.ReadLine();

            Console.Write("Dog Age: ");
            string inputDogAge = Console.ReadLine();
            int dogAge = int.Parse(inputDogAge);

            
            Dog myDog = new Dog(dogName, dogColour, dogAge);

            Console.WriteLine("Your dog's name is: " + myDog.Name);
            Console.WriteLine(",it has " + myDog.Age + "years old and is " + myDog.Colour);
            myDog.Eat();


            //-----Cat object-----
            Console.Write("Cat Name: ");
            string catName = Console.ReadLine();

            Console.Write("Cat Colour: ");
            string catColour = Console.ReadLine();

            Console.Write("Cat Age: ");
            string inputCatAge = Console.ReadLine();
            int catAge = int.Parse(inputCatAge);


            Cat myCat = new Cat(catName, catColour, catAge);

            Console.WriteLine("Your cat's name is: " + myCat.Name);
            Console.WriteLine(",it has " + myCat.Age + "years old and is " + myCat.Colour);
            myCat.Eat();


        }
    }
}
