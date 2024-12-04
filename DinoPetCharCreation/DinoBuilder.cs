namespace DinoPetCharCreation;

public abstract class DinoBuilder
{
    public abstract string Era { get; set; }
    public abstract string Habitat();
    public abstract string Breed();
}

public class TriassicDino : DinoBuilder
{
    DataArray data;
    private Methods method;
    private string era;
    private string habitat;
    private string breed;
    private string gender;

    public override string Era
    {
        get => era;
        set => era = value;
    }
    public override string Habitat()
    {
        method.DisplayMethod(data.habitat);
        Console.Write("Pick a habitat: ");
        return habitat = method.InputRead(data.habitat, 0);
    }


    public override string Breed()
    {
        bool repeat = false;
        do
        {
            switch (habitat)
            {
                case "Ocean":
                    Console.WriteLine("Available Dinosaur(s):");
                    Console.WriteLine($"1-{data.triassicBreeds[3]}");
                    bool repeat1 = false;
                    string choice;
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
                    } while (repeat1);

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
                    } while (repeat1);

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
                    } while (repeat1);

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
                    } while (repeat1);

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
                    } while (repeat1);

                    break;
                default:
                    Console.Clear();
                    repeat = true;
                    break;
            }
        } while (repeat);

        return "";
    }

    public string Gender()
    {
        
    }
}
