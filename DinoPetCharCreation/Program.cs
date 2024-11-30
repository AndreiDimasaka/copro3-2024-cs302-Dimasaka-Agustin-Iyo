using System;
using System.Text;

namespace DinoPetCharCreation
{
    public class Menu
    {
        static StringBuilder sb = new StringBuilder();
        public static void Main()
        {
            Console.WriteLine("Welcome to DinoPetCharCreation");
            DisplayMethod(Choices.era);
            choiceChecker(Console.ReadLine());
        }

        static void DisplayMethod(string[] arr)
        {
         
            Console.WriteLine("Choose the corresponding number");
            Console.WriteLine(sb.Append('-', 32));
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{arr[i]}");
            }
        }

        static void choiceChecker(string input)
        {
            if (input.ToLower() == "Triassic")
            {
                DisplayMethod(Choices.habitat);
                string habitat = Console.ReadLine();
                switch (habitat)
                {
                    case "Ocean":
                        Console.WriteLine(Choices.triassicBreeds[3]);
                        break;
                    default:
                        Console.WriteLine("End");
                        break;
                }
            }
        }

        public struct Choices
        {
            public Choices()
            {
            }

            public static string[] era = {"Triassic", "Jurassic", "Cretaceous"};
            public static string[] habitat = { "Ocean", "Forest", "Arid", "Mountains", "Beach" };
            public static string[] triassicBreeds = {"Eoraptor", "Herrerasaurus", "Plateosaurus", "Ichthyosaurus", "Pterosaurus"};
            public static string[] jurassicBreeds = {"Brachiosaurus", "Pterodactyl", "Herrerasaurus", "Stegosaurus"};
            public static string[] cretaceousBreeds = {"Triceratops", "Tyrannosaurus", "Brachiosaurus", "Pterodactyl", "Tylosaurus", "Oviraptor", "Troodon", "Ankylosaurus"};

        }
    }
}