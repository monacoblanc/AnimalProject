using System;

public class AnimalClass
{
	public static int AnimalCount = 0;


    public AnimalClass() //void will not return anything. It is a constructor method that will be called when an object is created.
    {
        Console.WriteLine("This animal is eating");
    }

    public class Dog : AnimalClass //Inheritance is used to inherit the properties of a class. Here, Dog class is inheriting the properties of AnimalClass.
    {
        public void DogClass()
        {
            Console.WriteLine("This dog is barking");
        }
    }

    public class Cat : AnimalClass
    {
        public void CatClass()
        {
            Console.WriteLine("This cat is meowing");
        }
    }


}
