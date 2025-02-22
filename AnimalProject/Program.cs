namespace AnimalProject
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Enter the Dog breed you want: ");
            var dogbreed = Console.ReadLine();
            Console.WriteLine("Enter the Dog name you want: ");
            var dogname = Console.ReadLine();

            do {
                if (string.IsNullOrEmpty(dogbreed) || string.IsNullOrEmpty(dogname)) {
                    Console.WriteLine("Error: there is an empty field. Please ensure all fields contain information.");
                }

                Console.WriteLine("Enter the Dog breed you want: ");
                dogbreed = Console.ReadLine();
                Console.WriteLine("Enter the Dog name you want: ");
                dogname = Console.ReadLine();

            } while (string.IsNullOrEmpty(dogbreed) || string.IsNullOrEmpty(dogname));
            //This loop will keep running until the user enters a value for both the dog breed and dog name.


            Dog dog2 = new(dogbreed, dogname);
            Console.WriteLine($"The dog breed is {dog2.Breed} and the dog name is {dog2.DogName}.");
            Console.WriteLine($"The number of dogs is {Dog.DogCount}.");
            //Dog.DogCount is a static variable. It is shared among all instances of a class. This dogCount can only be accessed by the Dog class and not by the instance of the class.
            //This is also a property. It is used to get the value of the dogCount variable not as a method or function.


        }
    }
}
