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
            // Console.WriteLine("In a world where mysteries lie in every corner of the land, civilization drastically " +
            //                   "changed when ancient ruins, forgotten in time, towered before humanity. Strange structures " +
            //                   "began to rise as tremors shook the earth, unearthing secrets buried deep underground. " +
            //                   "These are later named \"Monoliths,\" structures left behind by an ancient civilization " +
            //                   "that once coexisted with dinosaurs. As light poured out of them, creatures once thought " +
            //                   "to be extinct began to emerge from their deep slumber. Dinosaurs, terrifying beings that " +
            //                   "once ruled the land, the seas, and the sky. These events would be recorded as \"The Fracture,\" " +
            //                   "a pivotal point that would shape history.\n\n" +
            //                   "Numerous attempts were made to decipher the archaic records found inside the Monoliths, " +
            //                   "most of which ended in failure. Exploring the Monoliths also took great risk, and almost " +
            //                   "20 years passed before a breakthrough was made. Devices that allowed humans to commune " +
            //                   "with dinosaurs were discovered deep inside the ancient ruins. At their core were link stones, " +
            //                   "the missing piece of the puzzle. They are fragments from an ore deposit that glowed intensely when subjected to heat and pressure. " +
            //                   "\n\nThe link stones, believed to be the catalyst behind the revival of the dinosaurs, " +
            //                   "also allowed humanity to establish a bond with them. " +
            //                   "It proved that coexistence was possible, and now they are dependable companions. " +
            //                   "The Monoliths, still shrouded in mystery, are now braved by humans and dinosaurs together. " +
            //                   "\"Relic hunters,\" as they are called, now explore these ancient ruins to uncover the secrets of a bygone era. " +
            //                   "These explorers challenge the unknown in the hopes of finding fame, fortune, or maybe even the truth.");
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
            Console.Write("Pick a skin color: ");
            string skinColor = InputRead(Choices.skinColor, 0);
            DisplayMethod(Choices.skinPattern);
            Console.Write("Pick a sking pattern: ");
            string skinPattern = InputRead(Choices.skinPattern, 0);
            // FavoriteFood randomizer
            DisplayMethod(Choices.skinTexture);
            Console.Write("Pick a skin texture: ");
            string skinTexture = InputRead(Choices.skinTexture, 0);
            DisplayMethod(Choices.bodyFeatures);
            Console.Write("Pick a body feature: ");
            string bodyFeatures = InputRead(Choices.bodyFeatures, 0);
            DisplayMethod(Choices.facialFeatures);
            Console.Write("Pick a facial feature: ");
            string facialFeatures = InputRead(Choices.facialFeatures, 0);
            DisplayMethod(Choices.tailType);
            Console.Write("Pick a tail type: ");
            string tailType = InputRead(Choices.tailType, 0);
            DisplayMethod(Choices.behavior);
            Console.Write("Pick a behavior: ");
            string behavior = InputRead(Choices.behavior, 0);
            
            
            
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
            public static string[] favoriteFood = { "Meat", "Plants", "Fish", "Fruits", "Eggs" };
            public static string[] skinTexture = { "Feathered", "Rugged", "Scaly", "Smooth", "Fur" };
            public static string[] bodyFeatures = { "Armored", "Spiked", "Spined", "Normal" };
            public static string[] facialFeatures = { "Beak", "Horns", "Frills", "Sharp Teeth", "Spikes", "Flat Teeth"};
            public static string[] tailType = {"Spiked", "Clubbed", "Long", "Normal", "Short" };
            public static string[] behavior = { "Hunter", "Defender", "Worker", "Scout", "Leader" };
            

        }

        static void DisplayMethod(string[] arr)
        {
            Console.WriteLine();
            Console.WriteLine("Choose the corresponding number");
            sb.Clear();
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
                            Console.WriteLine("Available Dinosaur(s):");
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
                            Console.WriteLine("Available Dinosaur(s):");
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
                            Console.WriteLine("Available Dinosaur(s):");
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
                            Console.WriteLine("Available Dinosaur(s):");
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
                            Console.WriteLine("Available Dinosaur(s):");
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
                            Console.WriteLine("Available Dinosaur(s):");
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
                            Console.WriteLine("Available Dinosaur(s):");
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
                            Console.WriteLine("Available Dinosaur(s):");
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
                            Console.WriteLine("Available Dinosaur(s):");
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
                            Console.WriteLine("Available Dinosaur(s):");
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
                            Console.WriteLine("Available Dinosaur(s):");
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
                            Console.WriteLine("Available Dinosaur(s):");
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
                            Console.WriteLine("Available Dinosaur(s):");
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
                            Console.WriteLine("Available Dinosaur(s):");
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