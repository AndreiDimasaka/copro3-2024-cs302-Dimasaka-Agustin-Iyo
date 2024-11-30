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
            choiceChecker(InputRead());
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

        static string InputRead()
        {
            return Choices.habitat[int.Parse(Console.ReadLine()) - 1];
        }
        static void choiceChecker(string input)
        {
            if (input == "Triassic")
            {
                DisplayMethod(Choices.habitat);
                
                switch (InputRead())
                {
                    case "Ocean":
                        Console.WriteLine(Choices.triassicBreeds[3]);
                        break;
                    case "Forest":
                        Console.WriteLine(Choices.triassicBreeds[0]);
                        break;
                    case "Arid":
                        Console.WriteLine(Choices.triassicBreeds[1]);
                        break;
                    case "Mountains":
                        Console.WriteLine(Choices.triassicBreeds[2]);
                        break;
                    case "Beach":
                        Console.WriteLine(Choices.triassicBreeds[4]);
                        break;
                    default:
                        Console.WriteLine("End");
                        break;
                }

            }
            else if (input == "Jurassic")
            {
                switch (InputRead())
                {
                    case "Ocean":
                        Console.WriteLine(Choices.jurassicBreeds[0]);
                        break;
                    case "Forest":
                        Console.WriteLine(Choices.jurassicBreeds[1]);
                        break;
                    case "Arid":
                        Console.WriteLine(Choices.jurassicBreeds[2]);
                        break;
                    case "Mountains":
                        Console.WriteLine(Choices.jurassicBreeds[3]);
                        break;
                    case "Beach":
                        Console.WriteLine(Choices.jurassicBreeds[3]);
                        break;
                    default:
                        Console.WriteLine("End");
                        break;
                }
            }
            else if (input == "Cretaceous")
            {
                switch (InputRead())
                {
                    case "Ocean":
                        Console.WriteLine(Choices.cretaceousBreeds[0]);
                        break;
                    case "Forest":
                        Console.WriteLine(Choices.cretaceousBreeds[1]);
                        break;
                    case "Arid":
                        Console.WriteLine(Choices.cretaceousBreeds[2]);
                        break; 
                    case "Mountains":
                        Console.WriteLine(Choices.cretaceousBreeds[3]);
                        break;
                    case "Beach":
                        Console.WriteLine(Choices.cretaceousBreeds[4]);
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
            Dictionary<string, string> triassic = new Dictionary<string, string>();

            public static string[] triassicBreeds = {"Eoraptor", "Herrerasaurus", "Plateosaurus", "Ichthyosaurus", "Pterosaurus"};
            public static string[] jurassicBreeds = {"Brachiosaurus", "Pterodactyl", "Herrerasaurus", "Stegosaurus"};
            public static string[] cretaceousBreeds = {"Triceratops", "Tyrannosaurus", "Brachiosaurus", "Pterodactyl", "Tylosaurus", "Oviraptor", "Troodon", "Ankylosaurus"};

        }
    }
}