using System.Text;

namespace DinoPetCharCreation;

public class CretaceousDino : DinoBuilder, DinoBuild
{
    private DataArray data = new DataArray();
    private Methods method = new Methods();
    private string _era;
    private string _habitat;
    private string _breed;
    private string _gender;
    private string _nature;
    private string _skinColor1;
    private string _skinPattern;
    private string _skinTexture;
    private string _favoriteFood;
    private string _bodyFeatures;
    private string _facialFeatures;
    private string _tailType;
    private string _behavior;
    private string _name;
    private bool _wing;
    private bool _fins;
    private bool _claw;
    private StringBuilder sb = new StringBuilder();

    public CretaceousDino()
    {

    }

    public void BuildDinosaur()
    {
        Console.Clear();
        Console.WriteLine("Build Succeeded");
        Console.WriteLine($"Your dinosaur is a {_breed}");
        Console.WriteLine($"Period where your dinosaur lived in {_era}");
        Console.WriteLine($"Primarily stays at {_habitat}");
        Console.WriteLine($"Gender is a {_gender} ");
        Console.WriteLine($"Its nature is {_nature} ");
        Console.WriteLine($"Skin color(s): {_skinColor1} ");
        Console.WriteLine($"Skin pattern is a {_skinPattern} ");
        Console.WriteLine($"The texture of its skin is {_skinTexture} ");
        Console.WriteLine($"Its favorite food are {_favoriteFood} ");
        Console.WriteLine($"Its body features: {_bodyFeatures} ");
        if (hasClaw())
        {
            Console.WriteLine("It has sharp claws");
        }

        if (hasWing())
        {
            Console.WriteLine("It is a winged dinosaur");
        }

        if (hasFins())
        {
            Console.WriteLine("It is a marine dinosaur");
        }

        Console.WriteLine($"Its facial feature is a {_facialFeatures} ");
        Console.WriteLine($"Its tail is {_tailType} ");
        Console.WriteLine($"Its behavior is {_behavior} ");
        Console.WriteLine($"You named it {_name} ");
    }

    public override string Era
    {
        get => _era;
        set => _era = value;
    }

    public override string Habitat()
    {
        method.DisplayMethod(data.habitat);
        Console.Write("Pick a habitat: ");
        return _habitat = method.InputRead(data.habitat, 0);
    }


    public override string Breed()
    {
        Console.Clear();
        bool repeat = false;
        bool repeat1 = false;
        string choice;
        do
        {
            switch (_habitat)
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
                                return _breed = data.cretaceousBreeds[4];
                            default:
                                repeat1 = true;
                                Console.WriteLine("Invalid input. Try again.");
                                break;
                        }
                    } while (repeat1);

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
                                return _breed = data.cretaceousBreeds[0];
                            case "2":
                                return _breed = data.cretaceousBreeds[1];
                            case "3":
                                return _breed = data.cretaceousBreeds[2];
                            case "4":
                                return _breed = data.cretaceousBreeds[5];
                            case "5":
                                return _breed = data.cretaceousBreeds[6];
                            case "6":
                                return _breed = data.cretaceousBreeds[7];
                            default:
                                repeat1 = true;
                                Console.WriteLine("Invalid input. Try again.");
                                break;
                        }
                    } while (repeat1);

                    break;
                case "Arid":
                    Console.WriteLine("Available Dinosaur(s):");
                    Console.WriteLine($"1-{data.cretaceousBreeds[2]}");
                    Console.WriteLine($"2-{data.cretaceousBreeds[5]}");
                    do
                    {
                        Console.Write("Pick a dinosaur: ");
                        choice = (Console.ReadLine());
                        switch (choice)
                        {
                            case "1":
                                return _breed = data.cretaceousBreeds[2];
                            case "2":
                                return _breed = data.cretaceousBreeds[5];
                            default:
                                repeat1 = true;
                                Console.WriteLine("Invalid input. Try again.");
                                break;
                        }
                    } while (repeat1);

                    break;
                case "Mountains":
                    Console.WriteLine("Available Dinosaur(s):");
                    Console.WriteLine($"1-{data.cretaceousBreeds[0]}");
                    Console.WriteLine($"2-{data.cretaceousBreeds[1]}");
                    Console.WriteLine($"3-{data.cretaceousBreeds[3]}");
                    do
                    {
                        Console.Write("Pick a dinosaur: ");
                        choice = (Console.ReadLine());
                        switch (choice)
                        {
                            case "1":
                                return _breed = data.cretaceousBreeds[0];
                            case "2":
                                return _breed = data.cretaceousBreeds[1];
                            case "3":
                                return _breed = data.cretaceousBreeds[3];
                            default:
                                repeat1 = true;
                                Console.WriteLine("Invalid input. Try again.");
                                break;
                        }
                    } while (repeat1);

                    break;
                case "Beach":
                    Console.WriteLine("Available Dinosaur(s):");
                    Console.WriteLine($"1-{data.cretaceousBreeds[3]}");
                    Console.WriteLine($"2-{data.cretaceousBreeds[6]}");
                    Console.WriteLine($"3-{data.cretaceousBreeds[7]}");
                    do
                    {
                        Console.Write("Pick a dinosaur: ");
                        choice = (Console.ReadLine());
                        switch (choice)
                        {
                            case "1":
                                return _breed = data.cretaceousBreeds[3];
                            case "2":
                                return _breed = data.cretaceousBreeds[6];
                            case "3:":
                                return _breed = data.cretaceousBreeds[7];
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

    public override string Gender()
    {
        method.DisplayMethod(data.gender);
        Console.Write("Pick a gender: ");
        return _gender = method.InputRead(data.gender, 0);
    }

    public override string Nature()
    {
        method.DisplayMethod(data.nature);
        Console.Write("Pick a nature: ");
        return _nature = method.InputRead(data.nature, 0);
    }

    public override string SkinColor(string color)
    {
        return this._skinColor1 = color;
    }

    public string SkinColor(string color1, string color2)
    {
        return this._skinColor1 = $"{color1} , {color2}";
    }

    public override string SkinPattern()
    {
        method.DisplayMethod(data.skinPattern);
        Console.Write("Pick a skin pattern: ");
        return _skinPattern = method.InputRead(data.skinPattern, 0);
    }

    public override string SkinTexture()
    {
        method.DisplayMethod(data.skinTexture);
        Console.Write("Pick a skin texture: ");
        return _skinTexture = method.InputRead(data.skinTexture, 0);
    }

    public override string FavoriteFood()
    {
        switch (this._breed)
        {
            case "Triceratops":
                return _favoriteFood = data.favoriteFood[1];
            case "Tyrannosaurus":
                return _favoriteFood = data.favoriteFood[0];
            case "Brachiosaurus":
                return _favoriteFood = data.favoriteFood[1];
            case "Pterodactyl":
                return _favoriteFood = data.favoriteFood[2];
            case "Tylosaurus":
                return _favoriteFood = data.favoriteFood[2];
            case "Oviraptor":
                return _favoriteFood = data.favoriteFood[4];
            case "Troodon":
                return _favoriteFood = data.favoriteFood[4];
            case "Ankylosaurus":
                return _favoriteFood = data.favoriteFood[2];
        }

        return "";
    }

    public override string BodyFeatures()
    {
        method.DisplayMethod(data.bodyFeatures);
        Console.Write("Pick a body feature: ");
        return _bodyFeatures = method.InputRead(data.bodyFeatures, 0);
    }

    public override string FacialFeatures()
    {
        method.DisplayMethod(data.facialFeatures);
        Console.Write("Pick a face feature: ");
        return _facialFeatures = method.InputRead(data.facialFeatures, 0);
    }

    public override string TailType()
    {
        method.DisplayMethod(data.tailType);
        Console.Write("Pick a tail type: ");
        return _tailType = method.InputRead(data.tailType, 0);
    }

    public override string Behavior()
    {
        method.DisplayMethod(data.behavior);
        Console.Write("Pick a behavior: ");
        return _behavior = method.InputRead(data.behavior, 0);
    }

    public override string Name
    {
        get => _name;
        set => _name = value;
    }

    public void TraitsAmount()
    {
        Console.Clear();
        bool repeat1 = false;
        int add = 0;
        int total = 0;
        data.traits.Add("Speed", 0);
        data.traits.Add("Strength", 0);
        data.traits.Add("Intelligence", 0);
        data.traits.Add("Dexterity", 0);
        data.traits.Add("Toughness", 0);

        Console.WriteLine();
        Console.WriteLine("Allocate 40 points to your dinosaur stats, Max per stat is 20");
        sb.Clear();
        Console.WriteLine(sb.Append('-', 32));
        Console.WriteLine();

        foreach (KeyValuePair<string, int> elem in data.traits)
        {
            do
            {
                try
                {
                    repeat1 = false;
                    Console.Write($"{elem.Key}: ");
                    add = int.Parse(Console.ReadLine());
                    total += add;
                    if (add < 0 | add > 20)
                    {
                        total -= add;
                        Console.WriteLine("You can only allocate below 20 and above 0. Try again.");
                        repeat1 = true;
                    }
                    else if (total > 40)
                    {
                        total -= add;
                        Console.WriteLine($"You can only allocate 40 points, Your remaining points are {40 - total}. Try again.");
                        repeat1 = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Try again.");
                    repeat1 = true;
                }
            }while (repeat1);

            data.traits[elem.Key] = data.traits[elem.Key] + add;
        }
    }

    public void PrintTraits()
    {
        foreach (KeyValuePair<string, int> elem in data.traits)
        {
            Console.WriteLine($"{elem.Key}: {elem.Value}");
        }
    }

    public bool hasWing()
    {
        bool repeat = false;
        do
        {
            switch (this._breed)
            {
                case "Triceratops":
                    return _wing = false;
                case "Tyrannosaurus":
                    return _wing = false;
                case "Brachiosaurus":
                    return _wing = false;
                case "Pterodactyl":
                    return _wing = true;
                case "Tylosaurus":
                    return _wing = false;
                case "Oviraptor":
                    return _wing = false;
                case "Troodon":
                    return _wing = false;
                case "Ankylosaurus":
                    return _wing = false;
                default:
                    repeat = true;
                    Console.WriteLine("Invalid input. Try again.");
                    break;

            }
        } while (repeat);

        return false;
    }

    public bool hasFins()
    {
        bool repeat = false;
        do
        {
            switch (this._breed)
            {
                case "Triceratops":
                    return _fins = false;
                case "Tyrannosaurus":
                    return _fins = false;
                case "Brachiosaurus":
                    return _fins = false;
                case "Pterodactyl":
                    return _fins = false;
                case "Tylosaurus":
                    return _fins = true;
                case "Oviraptor":
                    return _fins = false;
                case "Troodon":
                    return _fins = false;
                case "Ankylosaurus":
                    return _fins = false;
                default:
                    repeat = true;
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        } while (repeat);

        return false;
    }

    public bool hasClaw()
    {
        bool repeat = false;
        do
        {
            switch (this._breed)
            {
                case "Triceratops":
                    return _claw = false;
                case "Tyrannosaurus":
                    return _claw = true;
                case "Brachiosaurus":
                    return _claw = true;
                case "Pterodactyl":
                    return _claw = true;
                case "Tylosaurus":
                    return _claw = false;
                case "Oviraptor":
                    return _claw = true;
                case "Troodon":
                    return _claw = true;
                case "Ankylosaurus":
                    return _claw = false;
                default:
                    repeat = true;
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        } while (repeat);

        return false;
    }
}
