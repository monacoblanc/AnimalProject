using Xunit;
using AnimalProject;
using System.IO;

namespace AnimalProject_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Dog_ObjectCreated_SetsPropertiesCorrectly()
        {
            //Arrange setup. This is where you set up the test.
            string breed = "Poodle";
            string dogname = "Rex";

            //Act. This is where you call the method you want to test.
            Dog dog = new(breed, dogname);

            //Assert Verify. This is where you verify that the method you called in the Act step did what you expected it to do.
            Assert.Equal(breed, dog.Breed);
            //Assert.Equal(expected, actual);
            Assert.Equal(dogname, dog.DogName);

        }
    }

    public class ConsoleInput_Test
    {
        [Fact]
        public void GetDogInput_ReturnsTrimmedInput()
        {
            // Arrange
            string breedInput = " lAbrador";
            string nameInput = "ER";
            string CombinedInput = $"{breedInput}\n{nameInput}\n";

            StringReader stringReader = new(CombinedInput);
            //StringReader is a class in the System.IO namespace. It is used to read a string from the console.
            Console.SetIn(stringReader);
            //Console.SetIn is a method in the System namespace. It is used to set the input stream to the specified TextReader.


            // Act. This is where you call the method you want to test.
            (string breed, string name) = ConsoleInput.GetDogInput();


            // Assert is where you verify that the method you called in the Act step did what you expected it to do.
            Assert.Equal("Labrador", breed);
            //Assert.Equal(expected, actual);
            Assert.Equal("ER", name);
        }
        /*
         Arrange is telling us that if we provide this input, and I call this method (Act), then
        we expect this output (Assert).
         */



        [Fact]
        public void GetDogInput_HandlesEmptyInput()
        {
            //Arrange
            string input = " \n \n Labrador \n Buddy \n";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            //Act
            (string breed, string name) = ConsoleInput.GetDogInput();

            //Assert
            Assert.Equal("Labrador", breed);
            Assert.Equal("Buddy", name);
        }



    }
}


