using System;
using System.Collections.Generic;
using Wildlife.Model;

namespace Wildlife
{
    class Program
    {
        public static void Main()
        {
           Animal zebra = new Animal("Tony", "Zebra", "1/12/20", true, false, "Male");
           Animal giraffe = new Animal("Geraldine", "Giraffe", "6/4/20", false, true, "Female");
           Animal penguin = new Animal("Pauly", "Penguin", "2/2/20", true, true, "Male");
           Animal shark = new Animal("Shirley", "Shark", "2/9/19", true, true, "Female");

        List<Animal> animals = new List<Animal>() {zebra, giraffe, penguin, shark};

            Console.WriteLine("Wildlife Managment");
            Console.WriteLine("-------------------");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1 to list all animals");
            Console.WriteLine("2 to mark an animal as fed/unfed");

            string menuEntry = Console.ReadLine();
            if (menuEntry == "1")
            {
                foreach(Animal individual in animals)
                {
                    Console.WriteLine(individual.GetAnimalName() + " " + individual.GetAnimalType()); 
                }
            }   
            else if (menuEntry == "2")
            {
                Console.WriteLine("Animals needing feeding: ");
                List<Animal> hungryAnimals = new List<Animal>();
                foreach(Animal individual in animals)
                {
                    if (individual.GetFeeding() == false)
                    {
                        hungryAnimals.Add(individual);
                    }
                }
                foreach(Animal individual in hungryAnimals)
                {
                    Console.WriteLine(individual.GetAnimalName() + " " + individual.GetAnimalType());
                }
            }
        }
    }
}
