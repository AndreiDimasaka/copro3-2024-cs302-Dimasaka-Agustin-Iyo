using System.Text;

namespace DinoPetCharCreation;

public class Methods
{
    static StringBuilder sb = new StringBuilder();
    static DataArray data = new DataArray();
    public void DisplayMethod(string[] arr)
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

        public string InputRead(string[] arr, int modify)
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

        public string PickDinosaur(string input)
        {
            bool repeat = false;
            bool repeat1 = false;
            string choice = "";
            do
            {
                if (input == "Triassic")
                {
                    DisplayMethod(data.habitat);
                    Console.Write("Pick a habitat: ");
                    string habitat = InputRead(data.habitat, 0);
                    switch (habitat)
                    {
                        case "Ocean":
                            Console.WriteLine("Available Dinosaur(s):");
                            Console.WriteLine($"1-{data.triassicBreeds[3]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return data.triassicBreeds[3];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        case "Forest":
                            Console.WriteLine("Available Dinosaur(s):");
                            Console.WriteLine($"1-{data.triassicBreeds[0]}");
                            Console.WriteLine($"2-{data.triassicBreeds[2]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return data.triassicBreeds[0];
                                    case "2":
                                        return data.triassicBreeds[2];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);

                            break;
                        case "Arid":
                            Console.WriteLine("Available Dinosaur(s):");
                            Console.WriteLine($"1-{data.triassicBreeds[1]}");
                            Console.WriteLine($"2-{data.triassicBreeds[2]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return data.triassicBreeds[1];
                                    case "2":
                                        return data.triassicBreeds[2];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        case "Mountains":
                            Console.WriteLine("Available Dinosaur(s):");
                            Console.WriteLine($"1-{data.triassicBreeds[1]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return data.triassicBreeds[1];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        case "Beach":
                            Console.WriteLine("Available Dinosaur(s):");
                            Console.WriteLine($"1-{data.triassicBreeds[4]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return data.triassicBreeds[4];
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
                    DisplayMethod(data.habitat);
                    Console.Write("Pick a habitat: ");
                    string habitat = InputRead(data.habitat, 0);
                    switch (habitat)
                    {
                        case "Ocean":
                            Console.WriteLine($"No dino breed is available.");
                            repeat = true;
                            break;
                        case "Forest":
                            Console.WriteLine("Available Dinosaur(s):");
                            Console.WriteLine($"1-{data.jurassicBreeds[0]}");
                            Console.WriteLine($"2-{data.jurassicBreeds[2]}");
                            Console.WriteLine($"3-{data.jurassicBreeds[3]}");
                            do{ 
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine()); 
                                switch (choice)
                            {
                                case "1":
                                    return data.jurassicBreeds[0];
                                case "2":
                                    return data.jurassicBreeds[2];
                                case "3":
                                    return data.jurassicBreeds[3];
                                default:
                                    repeat1 = true;
                                    Console.WriteLine("Invalid input. Try again.");
                                    break;
                            } 
                            }while(repeat1);
                            break;
                        case "Arid":
                            Console.WriteLine("Available Dinosaur(s):");
                            Console.WriteLine($"1-{data.jurassicBreeds[0]}");
                            Console.WriteLine($"2-{data.jurassicBreeds[2]}");
                            Console.WriteLine($"3-{data.jurassicBreeds[3]}");
                            do{ 
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine()); 
                                switch (choice)
                                {
                                    case "1":
                                        return data.jurassicBreeds[0];
                                    case "2":
                                        return data.jurassicBreeds[2];
                                    case "3":
                                        return data.jurassicBreeds[3];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                } 
                            }while(repeat1);
                            break;
                        case "Mountains":
                            Console.WriteLine("Available Dinosaur(s):");
                            Console.WriteLine($"1-{data.jurassicBreeds[2]}");
                            Console.WriteLine($"2-{data.jurassicBreeds[3]}");
                            Console.WriteLine($"3-{data.jurassicBreeds[1]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return data.jurassicBreeds[2];
                                    case "2":
                                        return data.jurassicBreeds[3];
                                    case "3":
                                        return data.jurassicBreeds[1];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        case "Beach":
                            Console.WriteLine("Available Dinosaur(s):");
                            Console.WriteLine($"1-{data.jurassicBreeds[1]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return data.jurassicBreeds[1];
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
                    DisplayMethod(data.habitat);
                    Console.Write("Pick a habitat: ");
                    string habitat = InputRead(data.habitat, 0);
                    switch (habitat)
                    {
                        case "Ocean":
                            Console.WriteLine("Available Dinosaur(s):");
                            Console.WriteLine($"1-{data.cretaceousBreeds[4]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return data.cretaceousBreeds[4];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        case "Forest":
                            Console.WriteLine("Available Dinosaur(s):");
                            Console.WriteLine($"1-{data.cretaceousBreeds[0]}");
                            Console.WriteLine($"2-{data.cretaceousBreeds[1]}");
                            Console.WriteLine($"3-{data.cretaceousBreeds[2]}");
                            Console.WriteLine($"4-{data.cretaceousBreeds[5]}");
                            Console.WriteLine($"5-{data.cretaceousBreeds[6]}");
                            Console.WriteLine($"6-{data.cretaceousBreeds[7]}");
                            do
                            {
                                Console.Write("Pick a dinosaur: ");
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return data.cretaceousBreeds[0];
                                    case "2":  
                                        return data.cretaceousBreeds[1];
                                    case "3": 
                                        return data.cretaceousBreeds[2];
                                    case "4":  
                                        return data.cretaceousBreeds[5];
                                    case "5":  
                                        return data.cretaceousBreeds[6];
                                    case "6":  
                                        return data.cretaceousBreeds[7];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);

                            break;
                        case "Arid":
                            Console.WriteLine("Available Dinosaur(s):");
                            Console.WriteLine($"1-{data.cretaceousBreeds[2]}");
                            Console.WriteLine($"2-{data.cretaceousBreeds[5]}");
                            do
                            {
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return data.cretaceousBreeds[2];
                                    case "2":  
                                        return data.cretaceousBreeds[5];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        case "Mountains":
                            Console.WriteLine("Available Dinosaur(s):");
                            Console.WriteLine($"1-{data.cretaceousBreeds[0]}");
                            Console.WriteLine($"2-{data.cretaceousBreeds[1]}");
                            Console.WriteLine($"3-{data.cretaceousBreeds[3]}");
                            do
                            {
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return data.cretaceousBreeds[0];
                                    case "2":  
                                        return data.cretaceousBreeds[1];
                                    case "3": 
                                        return data.cretaceousBreeds[3];
                                    default:
                                        repeat1 = true;
                                        Console.WriteLine("Invalid input. Try again.");
                                        break;
                                }
                            }while(repeat1);
                            break;
                        case "Beach":
                            Console.WriteLine("Available Dinosaur(s):");
                            Console.WriteLine($"1-{data.cretaceousBreeds[3]}");
                            Console.WriteLine($"2-{data.cretaceousBreeds[6]}");
                            Console.WriteLine($"3-{data.cretaceousBreeds[7]}");
                            do
                            {
                                choice = (Console.ReadLine());
                                switch (choice)
                                {
                                    case "1":
                                        return data.cretaceousBreeds[3];
                                    case "2":  
                                        return data.cretaceousBreeds[6];
                                    case "3:": 
                                        return data.cretaceousBreeds[7];
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

        public void showGameStory()
        {
            Console.Clear();
            Console.WriteLine("In a world where mysteries lie in every corner of the land, civilization drastically " +
            "changed when ancient ruins, forgotten in time, towered before humanity. Strange structures " +
            "began to rise as tremors shook the earth, unearthing secrets buried deep underground. " +
            "These are later named \"Monoliths,\" structures left behind by an ancient civilization " +
            "that once coexisted with dinosaurs. As light poured out of them, creatures once thought " +
            "to be extinct began to emerge from their deep slumber. Dinosaurs, terrifying beings that " +
            "once ruled the land, the seas, and the sky. These events would be recorded as \"The Fracture,\" " +
            "a pivotal point that would shape history.\n\n" +
            "Numerous attempts were made to decipher the archaic records found inside the Monoliths, " +
            "most of which ended in failure. Exploring the Monoliths also took great risk, and almost " +
            "20 years passed before a breakthrough was made. Devices that allowed humans to commune " +
            "with dinosaurs were discovered deep inside the ancient ruins. At their core were link stones, " +
            "the missing piece of the puzzle. They are fragments from an ore deposit that glowed intensely when subjected to heat and pressure. " +
            "\n\nThe link stones, believed to be the catalyst behind the revival of the dinosaurs, " +
            "also allowed humanity to establish a bond with them. " +
            "It proved that coexistence was possible, and now they are dependable companions. " +
            "The Monoliths, still shrouded in mystery, are now braved by humans and dinosaurs together. " +
            "\"Relic hunters,\" as they are called, now explore these ancient ruins to uncover the secrets of a bygone era. " +
            "These explorers challenge the unknown in the hopes of finding fame, fortune, or maybe even the truth.");
        }
        
    }
