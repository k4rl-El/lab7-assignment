using System;

namespace lab7_assignment
{
    //lab 7 - Question:Implement the following classes: Dog, Frog, Cat, Kitten and Tomcat.
    //All of them are animals (Animal).
    //Animals are characterized by age, name and gender.
    // Each animal makes a sound (use a virtual method in the Animal class).
    // Create an array of different animals and print on the console their name,
    // age and the corresponding sound each one makes.
    class Animals
    {
        public int  age
        {
            get; set;
        }
        public string  name
        {
            get; set;
        }
        public string gender
        {
            get; set; 
        }

        virtual public void sound()
        {
            Console.WriteLine("animal sound");
        }
    }
    class Dog: Animals
    {
        public Dog(int Age, string Name, string Gender)
        {
            age = Age;
            name = Name;
            gender = Gender;

        }
        public override void sound()
        {
            Console.WriteLine("woof!! woof!!");
        }
    
    }
    class Frog: Animals
    {
        public Frog(int Age, string Name, string Gender)
        {
            age = Age;
            name = Name;
            gender = Gender;

        }
        public override void sound()
        {
            Console.WriteLine("Ribbit!! Ribbit!!");
        }
    }
    class Kitten: Animals
    {
        public Kitten(int Age, string Name, string Gender)
        {
            age = Age;
            name = Name;
            gender = Gender;

        }
        public override void sound()
        {
            Console.WriteLine("purr!! purr!!");
        }
    
    }
    class Tomcat: Animals
    {
        public Tomcat(int Age, string Name, string Gender)
        {
            age = Age;
            name = Name;
            gender = Gender;

        }
        public override void sound()
        {
            Console.WriteLine("meow!! meow!!");
        }
    
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Animals myDog = new Dog(13, "toy", "female");
            Animals myFrog = new Frog(10, "kermit", "male");
            Animals myKitten = new Kitten(1, "fluffy", "female");
            Animals myTomcat = new Tomcat(13, "thomas", "male");
            Animals[] animals = {myDog, myFrog, myKitten, myTomcat};
            foreach(Animals animal in animals)
            {
                Console.WriteLine(animal.name);
                Console.WriteLine(animal.age);
                animal.sound();
                Console.WriteLine(" ");
                
            }
        }
    }
}