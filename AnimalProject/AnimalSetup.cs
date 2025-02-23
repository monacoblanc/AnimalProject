using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public static class ConsoleInput
    {
        public static (string breed, string name) GetDogInput() {
            //This syntax used a tuple to return multiple values from a method. The method returns a tuple with two values.
            //When to use a tuple: When you want to return multiple values from a method.

            string dogbreed = "";
            string dogname = "";

            do {
                Console.WriteLine("Enter the Dog breed you want: ");
                dogbreed = Console.ReadLine()?.Trim() ?? string.Empty;
                Console.WriteLine("Enter the Dog name you want: ");
                dogname = Console.ReadLine()?.Trim() ?? string.Empty;

                if (string.IsNullOrEmpty(dogbreed) || string.IsNullOrEmpty(dogname)) {
                    DisplayEmptyFieldError();
                }


            } while (string.IsNullOrEmpty(dogbreed) || string.IsNullOrEmpty(dogname));
            return (dogbreed, dogname);
            //This returns a tuple with two values.
        }

        private static void DisplayEmptyFieldError() {
            Console.WriteLine("Error: there is an empty field. Please ensure all fields contain information.");
        }
    }



    public class Animals {
        public void Animaleat () {
            Console.WriteLine("This animal is eating.");
        }
    }

    public class Dog : Animals
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
