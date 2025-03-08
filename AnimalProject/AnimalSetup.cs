using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    internal static class ConsoleInput {//I/O operations are performed in this class.
        internal static (string breed, string name) GetDogInput() {
            //This syntax used a tuple to return multiple values from a method. The method returns a tuple with two values.
            //When to use a tuple: When you want to return multiple values from a method.

            string dogbreed = "";
            string dogname = "";

            do {
                dogbreed = InputHelper.GetInput("Enter the Dog breed you want: ");
                dogname = InputHelper.GetInput("Enter the Dog name you want: ");

                if (InputHelper.IsEmptyInput(dogbreed, dogname)) {
                    InputHelper.DisplayEmptyField_and_type_Error();
                }


            } while (string.IsNullOrEmpty(dogbreed) || string.IsNullOrEmpty(dogname));
            return (dogbreed, dogname);
            //This returns a tuple with two values.
        }
    
        internal static int GetAnimalCount (string AnimalType) {

            int AnimalCount = 0;
            string AnimalRequested;

            while (true) {
                AnimalRequested = InputHelper.GetInput($"How many {AnimalType}s do you want to adopt? ");
                if (int.TryParse(AnimalRequested, out AnimalCount)) {
                    break;
                }

                else {
                    InputHelper.DisplayEmptyField_and_type_Error();
                }
            }
            return AnimalCount;

        }
    
    }


    public static class ObjectCreation {
        public static void CreateDogObject() {

            do {

                int dogCount = ConsoleInput.GetAnimalCount("Dog");

                
                for (int i = 0; i < dogCount; i++) {

                    (string breed, string name) = ConsoleInput.GetDogInput();
                    Dog dog = new(breed, name);


                    Console.WriteLine($"You have created a {dog.Breed} dog named {dog.DogName}.");
                    Console.WriteLine($"You have created {Dog.DogCount} dog(s).");
                    dogCount++;
                }
                    break;
                

            } while (false);
        }
    }



    //Object Declaration
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



    //Additional Security Protocol
    internal static class InputHelper
    {
        internal static string GetInput(string prompt) {
            //internal is used to make the method accessible to the entire assembly but not to other assemblies.
            Console.WriteLine(prompt);
            return Console.ReadLine()?.Trim() ?? string.Empty;
        }

        internal static bool IsEmptyInput(string breed, string dogname) {
            return string.IsNullOrEmpty(breed) || string.IsNullOrEmpty(dogname);
        }

        internal static void DisplayEmptyField_and_type_Error() {
            Console.WriteLine("Error: There is an empty field or invalid Input. Please ensure all fields contain information and correct.");
        }



    }

}


