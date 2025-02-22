using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    class Animals {
        public void Animaleat () {
            Console.WriteLine("This animal is eating.");
        }
    }

    class Dog : Animals
    { //This is inheritance. Dog class is inheriting from Animals class.
        public string Breed { get; set; } //Getters and setters are used to access and update the properties of a class.
        public string DogName { get; set; }
        private static int dogCount = 0;
        //This is a static variable. It is shared among all instances of a class. This dogCount can only be accessed by the Dog class and not by the instance of the class.
        //When using a constructor, the compiler does not recognize the initialization of the required properties.

        public static int DogCount //This belong to the class and not to the instance of the class.
        { //This is a property. It is used to get the value of the dogCount variable not as a method or function.
            get { 
                return dogCount; 
            }
        }


        public Dog (string breed, string dogname) {
            Breed = breed;
            DogName = dogname;
            dogCount++;
        }



    }
}
