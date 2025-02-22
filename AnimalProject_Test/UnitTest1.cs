using Xunit;
using AnimalProject;


namespace AnimalProject_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Dog_ObjectCreated_SetsPropertiesCorrectly() {
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
}