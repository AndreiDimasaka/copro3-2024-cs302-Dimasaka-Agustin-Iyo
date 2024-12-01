using System;
using System.Text;
using System.Xml.XPath;

namespace DinoPetCharCreation
{
    public class Menu
    {
        static StringBuilder sb = new StringBuilder();
        public static void Main()
        {
            Console.WriteLine("Welcome to DinoPetCharCreation");
            DisplayMethod(Choices.era);
            Console.Write("Pick an era: ");
            string era = InputRead(Choices.era, 0);
            string dinosaurBreed = PickDinosaur(era);
            DisplayMethod(Choices.gender);
            Console.Write("Pick a gender: ");
            string gender = InputRead(Choices.gender, 0);
            DisplayMethod(Choices.nature);
            Console.Write("Pick a nature: ");
            string nature = InputRead(Choices.nature, 0);
            DisplayMethod(Choices.skinColor);
            string skinColor = InputRead(Choices.skinColor, 0);
            DisplayMethod(Choices.skinPattern);
            string skinPattern = InputRead(Choices.skinPattern, 0);
            // FavoriteFood randomizer
            DisplayMethod(Choices.skinTexture);
            string skinTexture = InputRead(Choices.skinTexture, 0);
            
            
            
        }
        private struct Choices
        {
            public Choices()
            {
            }
            public static string[] era = {"Triassic", "Jurassic", "Cretaceous"};
            public static string[] habitat = { "Ocean", "Forest", "Arid", "Mountains", "Beach" };
            public static string[] triassicBreeds = {"Eoraptor", "Herrerasaurus", "Plateosaurus", "Ichthyosaurus", "Pterosaurus"};
            public static string[] jurassicBreeds = {"Brachiosaurus", "Pterodactyl", "Herrerasaurus", "Stegosaurus"};
            public static string[] cretaceousBreeds = {"Triceratops", "Tyrannosaurus", "Brachiosaurus", "Pterodactyl", "Tylosaurus", "Oviraptor", "Troodon", "Ankylosaurus"};
            public static string[] gender = { "Male", "Female" };
            public static string[] nature = { "Aggressive", "Workaholic", "Guardian", "Traveler", "Commander" };
            public static string[] skinColor = { "Gray", "Brown", "Red", "Black", "Blue" };
            public static string[] skinPattern = {"Spotted", "Stripped", "Solid" };
            public static string[] skinTexture = { "Feathered", "Rugged", "Scaly", "Smooth", "Fur" };
            
        }

        static void DisplayMethod(string[] arr)
        {
            Console.WriteLine();
            Console.WriteLine("Choose the corresponding number");
            Console.WriteLine(sb.Append('-', 32));
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{arr[i]}");
            }
        }

        static string InputRead(string[] arr, int modify)
        {
            bool error = false;
            do
            {
                try
                {
                    string result = arr[int.Parse(Console.ReadLine()) - 1 + modify];
                    return result;
                }
                catch (IndexOutOfRangeException e)

                {
                    Console.WriteLine("Invalid input. Try again.");
                    Console.Write("Answer: ");
                    error = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid input. Try again.");
                    Console.Write("Answer: ");
                    error = true;
                }
            }while (error);

            return null;
        }

        static string PickDinosaur(string input)
        {
            bool repeat = false;
            bool repeat1 = false;
            string choice = "";
            do
            {
                if (input == "Triassic")
                {
                    DisplayMethod(Choices.habitat);
                    Console.Write("Pick a habitat: ");
                    string habitat = InputRead(Choices.habitat, 0);
                    switch (habitat)
                    {
                        case "Ocean":
                            Console.WriteLine($"1-{Choices.triassicBreeds[3]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return Choices.triassicBreeds[3];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        case "Forest":
                            Console.WriteLine($"1-{Choices.triassicBreeds[0]}");
                            Console.WriteLine($"2-{Choices.triassicBreeds[2]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return Choices.triassicBreeds[0];
                                    case "2":
                                        return Choices.triassicBreeds[2];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);

                            break;
                        case "Arid":
                            Console.WriteLine($"1-{Choices.triassicBreeds[1]}");
                            Console.WriteLine($"2-{Choices.triassicBreeds[2]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return Choices.triassicBreeds[1];
                                    case "2":
                                        return Choices.triassicBreeds[2];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        case "Mountains":
                            Console.WriteLine($"1-{Choices.triassicBreeds[1]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return Choices.triassicBreeds[1];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        case "Beach":
                            Console.WriteLine($"1-{Choices.triassicBreeds[4]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return Choices.triassicBreeds[4];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        default:
                            Console.Clear();
                            repeat = true;
                            break;
                    }
                }

                else if (input == "Jurassic")
                {
                    DisplayMethod(Choices.habitat);
                    Console.Write("Pick a habitat: ");
                    string habitat = InputRead(Choices.habitat, 0);
                    switch (habitat)
                    {
                        case "Ocean":
                            Console.WriteLine($"No dino breed is available.");
                            repeat = true;
                            break;
                        case "Forest":
                            Console.WriteLine($"1-{Choices.jurassicBreeds[0]}");
                            Console.WriteLine($"2-{Choices.jurassicBreeds[2]}");
                            Console.WriteLine($"3-{Choices.jurassicBreeds[3]}");
                            do{ 
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine()); 
                                switch (choice)
                            {
                                case "1":
                                    return Choices.jurassicBreeds[0];
                                case "2":
                                    return Choices.jurassicBreeds[2];
                                case "3":
                                    return Choices.jurassicBreeds[3];
                                default:
                                    repeat1 = true;
                                    Console.WriteLine("Invalid input. Try again.");
                                    break;
                            } 
                            }while(repeat1);
                            break;
                        case "Arid":
                            Console.WriteLine($"1-{Choices.jurassicBreeds[0]}");
                            Console.WriteLine($"2-{Choices.jurassicBreeds[2]}");
                            Console.WriteLine($"3-{Choices.jurassicBreeds[3]}");
                            do{ 
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine()); 
                                switch (choice)
                                {
                                    case "1":
                                        return Choices.jurassicBreeds[0];
                                    case "2":
                                        return Choices.jurassicBreeds[2];
                                    case "3":
                                        return Choices.jurassicBreeds[3];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                } 
                            }while(repeat1);
                            break;
                        case "Mountains":
                            Console.WriteLine($"1-{Choices.jurassicBreeds[2]}");
                            Console.WriteLine($"2-{Choices.jurassicBreeds[3]}");
                            Console.WriteLine($"3-{Choices.jurassicBreeds[1]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return Choices.jurassicBreeds[2];
                                    case "2":
                                        return Choices.jurassicBreeds[3];
                                    case "3":
                                        return Choices.jurassicBreeds[1];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        case "Beach":
                            Console.WriteLine($"1-{Choices.jurassicBreeds[1]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return Choices.jurassicBreeds[1];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        default:
                            Console.Clear();
                            repeat = true;
                            break;
                    }
                }
                else if (input == "Cretaceous")
                {
                    DisplayMethod(Choices.habitat);
                    Console.Write("Pick a habitat: ");
                    string habitat = InputRead(Choices.habitat, 0);
                    switch (habitat)
                    {
                        case "Ocean":
                            Console.WriteLine($"1-{Choices.cretaceousBreeds[4]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return Choices.cretaceousBreeds[4];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        case "Forest":
                            Console.WriteLine($"1-{Choices.cretaceousBreeds[0]}");
                            Console.WriteLine($"2-{Choices.cretaceousBreeds[1]}");
                            Console.WriteLine($"3-{Choices.cretaceousBreeds[2]}");
                            Console.WriteLine($"4-{Choices.cretaceousBreeds[5]}");
                            Console.WriteLine($"5-{Choices.cretaceousBreeds[6]}");
                            Console.WriteLine($"6-{Choices.cretaceousBreeds[7]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return Choices.cretaceousBreeds[0];
                                    case "2":
                                        return Choices.cretaceousBreeds[1];
                                    case "3":
                                        return Choices.cretaceousBreeds[2];
                                    case "4":
                                        return Choices.cretaceousBreeds[5];
                                    case "5":
                                        return Choices.cretaceousBreeds[6];
                                    case "6":
                                        return Choices.cretaceousBreeds[7];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);

                            break;
                        case "Arid":
                            Console.WriteLine($"1-{Choices.cretaceousBreeds[2]}");
                            Console.WriteLine($"2-{Choices.cretaceousBreeds[5]}");
                            do
                            {
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return Choices.cretaceousBreeds[2];
                                    case "2":
                                        return Choices.cretaceousBreeds[5];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        case "Mountains":
                            Console.WriteLine($"1-{Choices.cretaceousBreeds[0]}");
                            Console.WriteLine($"2-{Choices.cretaceousBreeds[1]}");
                            Console.WriteLine($"3-{Choices.cretaceousBreeds[3]}");
                            do
                            {
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return Choices.cretaceousBreeds[0];
                                    case "2":
                                        return Choices.cretaceousBreeds[1];
                                    case "3":
                                        return Choices.cretaceousBreeds[3];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        case "Beach":
                            Console.WriteLine($"1-{Choices.cretaceousBreeds[3]}");
                            Console.WriteLine($"2-{Choices.cretaceousBreeds[6]}");
                            Console.WriteLine($"3-{Choices.cretaceousBreeds[7]}");
                            do
                            {
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return Choices.cretaceousBreeds[3];
                                    case "2":
                                        return Choices.cretaceousBreeds[6];
                                    case "3:":
                                        return Choices.cretaceousBreeds[7];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        default:
                            Console.Clear();
                            repeat = true;
                            break;
                    }
                }
            } while (repeat);
            return null; 
        }
        
    }
}