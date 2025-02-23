namespace AnimalProject
{
    class Program
    {
        static void Main(string[] args) {

            try
            {
                (string breed, string name) = ConsoleInput.GetDogInput();
                Dog dog = new(breed, name);

                Console.WriteLine($"The dog breed is {dog.Breed} and the dog name is {dog.DogName}.");
                Console.WriteLine($"The number of dogs is {Dog.DogCount}.");

            }

            finally
            {
                Console.WriteLine("The program has ended.");
            }



        }
    }
}
