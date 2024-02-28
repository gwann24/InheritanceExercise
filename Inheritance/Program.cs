using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird eagle = new Bird()
            {
                Legs = 2,
                Color = "Brown",
                LaysEggs = true,
                Active = "Diurnal",
                Flightless = false,
                Diet = "Carnivore",
                HasTeeth = false,
                Migrates = false
            };
            Console.WriteLine("\nCharacteristics of an Eagle:\n\n");
            Console.WriteLine(String.Format("+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}|", "------------"));
            Console.WriteLine(String.Format("|{0,12}|{1,12}|{2,12}|{3,12}|{4,12}|{5,12}|{6,12}|{7,12}|","Legs","Color","Lays Eggs","Active","Flightless","Diet","Has Teeth","Migrates"));
            Console.WriteLine(String.Format("+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}|", "------------"));
            Console.WriteLine(String.Format("|{0,12}|{1,12}|{2,12}|{3,12}|{4,12}|{5,12}|{6,12}|{7,12}|", eagle.Legs, eagle.Color, eagle.LaysEggs, eagle.Active, eagle.Flightless, eagle.Diet, eagle.HasTeeth, eagle.Migrates));
            Console.WriteLine(String.Format("+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}|", "------------"));

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile boa = new Reptile()
            {
                Legs = 2,
                Color = "Brown",
                LaysEggs = true,
                Active = "Diurnal",
                Poisonous = false,
                Constrictor = true,
                HasShell = false,
                Habitat = "Land"
            };
            Console.WriteLine("\nCharacteristics of an Boa:\n\n");
            Console.WriteLine(String.Format("+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}|", "------------"));
            Console.WriteLine(String.Format("|{0,12}|{1,12}|{2,12}|{3,12}|{4,12}|{5,12}|{6,12}|{7,12}|", "Legs", "Color", "Lays Eggs", "Active", "Poisonous", "Constrictor", "Shell", "Habitat"));
            Console.WriteLine(String.Format("+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}|", "------------"));
            Console.WriteLine(String.Format("|{0,12}|{1,12}|{2,12}|{3,12}|{4,12}|{5,12}|{6,12}|{7,12}|", boa.Legs, boa.Color, boa.LaysEggs, boa.Active, boa.Poisonous, boa.Constrictor, boa.HasShell, boa.Habitat ));
            Console.WriteLine(String.Format("+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}+{0,12}|", "------------"));

        }
    }
}
