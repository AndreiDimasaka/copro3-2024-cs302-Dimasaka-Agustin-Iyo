using System.Text;

namespace DinoPetCharCreation;

public abstract class DinoBuilder
{
    public abstract string Era { get; set; }

    public abstract string Habitat();
    public abstract string Breed();
    public abstract string Gender();
    public abstract string Nature();
    public abstract string SkinColor(string color);
    public abstract string SkinPattern();
    public abstract string SkinTexture();
    public abstract string FavoriteFood();
    public abstract string BodyFeatures();
    public abstract string FacialFeatures();
    public abstract string TailType();
    public abstract string Behavior();
    public abstract string Name { get; set; }

}
public interface DinoBuild
{
    IEnumerable<int> TraitsAmount();
    bool hasWing();
    bool hasFins();
    bool hasClaw();
}

public class TriassicDino : DinoBuilder,DinoBuild
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
    public TriassicDino()
    {
        
    }
    public void BuildDinosaur()
    {
        Console.WriteLine("Build Succeeded");
        Console.WriteLine($"Your dinosaur is a {_breed}");
        Console.WriteLine($"Period where your dinosaur lived in {_era}");
        Console.WriteLine($"Primarily stays at {_habitat}");
        Console.WriteLine($"Gender is a {_gender} ");
        Console.WriteLine($"Its nature is {_nature} ");
        Console.WriteLine($"Skin color(s): {_skinColor1} ");
        Console.WriteLine($"Skin pattern is a {_skinPattern} ");
        Console.WriteLine($"The texture of its skin is {_skinTexture } ");
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
        get => _era; set => _era = value;
    }

    public override string Habitat()
    {
        method.DisplayMethod(data.habitat);
        Console.Write("Pick a habitat: ");
        return _habitat = method.InputRead(data.habitat, 0);
    }


    public override string Breed()
    {
        bool repeat = false;
        do
        {
            switch (this._habitat)
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
                                return _breed = data.triassicBreeds[3];
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
                                return _breed = data.triassicBreeds[0];
                            case "2":
                                return _breed = data.triassicBreeds[2];
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
                                return _breed = data.triassicBreeds[1];
                            case "2":
                                return _breed = data.triassicBreeds[2];
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
                                return _breed = data.triassicBreeds[1];
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
                                return _breed = data.triassicBreeds[4];
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
       return  this._skinColor1 = $"{color1} , {color2}";
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
        return _skinTexture = method.InputRead(data.skinPattern, 0);
    }

    public override string FavoriteFood()
    {
        switch (this._breed)
        {
            case "Eoraptor":
                return _favoriteFood = $"{data.favoriteFood[0]}, {data.favoriteFood[1]}";
            case "Herrerasaurus":
                return _favoriteFood = data.favoriteFood[0];
            case "Plateosaurus":
                return _favoriteFood = data.favoriteFood[1];
            case "Ichthyosaurus":
                return _favoriteFood = data.favoriteFood[2];
            case "Pterosaurus":
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
        get => _name; set => _name = value;
    }

    public IEnumerable<int> TraitsAmount()
    {
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
            Console.WriteLine($"{elem.Key}: {elem.Value}");
        }
        foreach (KeyValuePair<string, int> elem in data.traits)
        {
            Console.Write($"{elem.Key}: ");
            do
            {
                try
                {
                    add = int.Parse(Console.ReadLine());
                    if (add < 0 | add > 20)
                    {
                                Console.WriteLine("You can only allocate below 20 and above 0. Try again.");
                                repeat1 = true;
                    }
                    else if (total > 41)
                    {
                        Console.Write($"You can only allocate 40 points, Your remaining points are {total - 40}. Try again.");
                    }
                }
                catch (FormatException)
                {
                            Console.WriteLine("Invalid input. Try again.");
                            repeat1 = true;
                }
                yield return data.traits[elem.Key] = data.traits[elem.Key] + add;
            }while (repeat1) ;  
        }
    }

    public bool hasWing()
    {
        bool repeat = false;
        do
        {
            switch (this._breed)
            {
                case "Eoraptor":
                    return _wing = false;
                case "Herrerasaurus":
                    return _wing = false;
                case "Plateosaurus":
                    return _wing = false;
                case "Ichthyosaurus":
                    return _wing = false;
                case "Pterosaurus":
                    return _wing = true;
                default:
                    repeat = true;
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        }while (repeat);

        return false;
    }

    public bool hasFins()
    {
       bool repeat = false;
       do
       {
           switch (this._breed)
           {
               case "Eoraptor":
                   return _fins = false;
               case "Herrerasaurus":
                   return _fins = false;
               case "Plateosaurus":
                   return _fins = false;
               case "Ichthyosaurus":
                   return _fins = true;
               case "Pterosaurus":
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
                case "Eoraptor":
                    return _claw = true;
                case "Herrerasaurus":
                    return _claw = true;
                case "Plateosaurus":
                    return _claw = true;
                case "Ichthyosaurus":
                    return _claw = false;
                case "Pterosaurus":
                    return _claw = true;
                default:
                    repeat = true;
                    Console.WriteLine("Invalid input. Try again.");
                    break;

            }
        }while (repeat); 
        return false;
    }
}
public class JurassicDino : DinoBuilder,DinoBuild
{
    private DataArray data = new DataArray();
    private Methods method = new Methods();
    private string _era { get; set; }
    private string _habitat { get; set; }
    private string _breed {get; set;}
    private string _gender { get; set; }
    private string _nature { get; set; }
    private string _skinColor1 { get; set; }
    private string _skinPattern { get; set; }
    private string _skinTexture { get; set; }
    private string _favoriteFood { get; set; }
    private string _bodyFeatures { get; set; }    
    private string _facialFeatures { get; set; }
    private string _tailType { get; set; }
    private string _behavior { get; set; }
    private string _name { get; set; }
    private bool _wing { get; set; }
    private bool _fins { get; set; }
    private bool _claw { get; set; }
    private StringBuilder sb = new StringBuilder();

    public JurassicDino()
    {
        
    }
    public JurassicDino(string build)
    {
        Console.WriteLine(build);
        Console.WriteLine($"Your dinosaur is a {_breed}");
        Console.WriteLine($"Period where your dinosaur lived in{_era}");
        Console.WriteLine($"Primarily stays at {_habitat}");
        Console.WriteLine($"Gender is a {_gender} ");
        Console.WriteLine($"Its nature is {_nature} ");
        Console.WriteLine($"Skin color(s): {_skinColor1} ");
        Console.WriteLine($"Skin pattern is a {_skinPattern} ");
        Console.WriteLine($"The texture of its skin is {_skinTexture} ");
        Console.WriteLine($"Its favorite food are {_favoriteFood} ");
        Console.WriteLine($"Its body features: {_bodyFeatures} ");
        if (_claw)
        {
            Console.WriteLine("It has sharp claws");
        } 
        if (_wing)
        {
            Console.WriteLine("It is a winged dinosaur");
        } 
        if (_fins)
        {
            Console.WriteLine("It is a marine dinosaur");
        }
        Console.WriteLine($"Has a facial features: {_facialFeatures} ");
        Console.WriteLine($"Its tail is {_tailType} ");
        Console.WriteLine($"Its behavior is {_behavior } ");
        Console.WriteLine($"You named it {_name} ");
    }
    public override string Era
    {
        get => _era; set => _era = value;
    }

    public override string Habitat()
    {
        method.DisplayMethod(data.habitat);
        Console.Write("Pick a habitat: ");
        return _habitat = method.InputRead(data.habitat, 0);
    }


    public override string Breed()
    { 
        bool repeat = false;
        string choice;
        do
        {
            bool repeat1 = false;
                    switch (_habitat)
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
                                    return _breed = data.jurassicBreeds[0];
                                case "2":
                                    return _breed = data.jurassicBreeds[2];
                                case "3":
                                    return _breed = data.jurassicBreeds[3];
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
                                        return _breed = data.jurassicBreeds[0];
                                    case "2":
                                        return _breed = data.jurassicBreeds[2];
                                    case "3":
                                        return _breed = data.jurassicBreeds[3];
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
                                        return _breed = data.jurassicBreeds[2];
                                    case "2":
                                        return _breed = data.jurassicBreeds[3];
                                    case "3":
                                        return _breed = data.jurassicBreeds[1];
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
                                        return _breed = data.jurassicBreeds[1];
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
       return  this._skinColor1 = $"{color1} , {color2}";
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
            case "Brachiosaurus":
                return _favoriteFood = data.favoriteFood[1];
            case "Pterodactyl":
                return _favoriteFood = data.favoriteFood[2];
            case "Herrerasaurus":
                return _favoriteFood = data.favoriteFood[0];
            case "Stegosaurus":
                return _favoriteFood = $"{data.favoriteFood[1]}, {data.favoriteFood[3]}";
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
        get => _name; set => _name = value;
    }
    public IEnumerable<int> TraitsAmount()
    {
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
            Console.WriteLine($"{elem.Key}: {elem.Value}");
        }
        foreach (KeyValuePair<string, int> elem in data.traits)
        {
            Console.Write($"{elem.Key}: ");
            do
            {
                try
                {
                    add = int.Parse(Console.ReadLine());
                    if (add < 0 | add > 20)
                    {
                        Console.WriteLine("You can only allocate below 20 and above 0. Try again.");
                        repeat1 = true;
                    }
                    else if (total > 41)
                    {
                        Console.Write($"You can only allocate 40 points, Your remaining points are {total - 40}. Try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Try again.");
                    repeat1 = true;
                }
                yield return data.traits[elem.Key] = data.traits[elem.Key] + add;
            }while (repeat1) ;  
        }
    }

    public bool hasWing()
    {
        bool repeat = false;
        do
        {
            switch (this._breed)
            {
                case "Brachiosaurus":
                    return _wing = false;
                case "Pterodactyl":
                    return _wing = true;
                case "Herrerasaurus":
                    return _wing = false;
                case "Stegosaurus":
                    return _wing = false;
                default:
                    repeat = true;
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        }while (repeat);

        return false;
    }

    public bool hasFins()
    {
       bool repeat = false;
       do
       {
           switch (this._breed)
           {
               case "Brachiosaurus":
                   return _fins = false;
               case "Pterodactyl":
                   return _fins = false;
               case "Herrerasaurus":
                   return _fins = false;
               case "Stegosaurus":
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
                case "Brachiosaurus":
                    return _claw = true;
                case "Pterodactyl":
                    return _claw = true;
                case "Herrerasaurus":
                    return _claw = true;
                case "Stegosaurus":
                    return _claw = false;
                default:
                    repeat = true;
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        }while (repeat); 
        return false;
    }
}

public class CretaceousDino : DinoBuilder,DinoBuild
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
    public CretaceousDino(string era, string habitat, string breed, string gender, string nature, string skinColor1, string skinPattern, string skinTexture, string favoriteFood, string bodyFeatures, string facialFeatures, string tailType
        , string behavior, string name)
    {
        Console.WriteLine($"Your dinosaur is a {_breed = breed}");
        Console.WriteLine($"Period where your dinosaur lived in{_era = era}");
        Console.WriteLine($"Primarily stays at {_habitat = habitat}");
        Console.WriteLine($"Gender is a {_gender = gender} ");
        Console.WriteLine($"Its nature is {_nature = nature} ");
        Console.WriteLine($"Skin color(s): {_skinColor1 = skinColor1} ");
        Console.WriteLine($"Skin pattern is a {_skinPattern = skinPattern} ");
        Console.WriteLine($"The texture of its skin is {_skinTexture = skinTexture} ");
        Console.WriteLine($"Its favorite food are {_favoriteFood = favoriteFood} ");
        Console.WriteLine($"Its body features: {_bodyFeatures = bodyFeatures} ");
        if (_claw)
        {
            Console.WriteLine("It has sharp claws");
        } 
        if (_wing)
        {
            Console.WriteLine("It is a winged dinosaur");
        } 
        if (_fins)
        {
            Console.WriteLine("It is a marine dinosaur");
        }
        Console.WriteLine($"Has a facial features: {_facialFeatures = facialFeatures} ");
        Console.WriteLine($"Its tail is {_tailType = tailType} ");
        Console.WriteLine($"Its behavior is {_behavior = behavior} ");
        Console.WriteLine($"You named it {_name = name} ");
    }
    public override string Era
    {
        get => _era; set => _era = value;
    }

    public override string Habitat()
    {
        method.DisplayMethod(data.habitat);
        Console.Write("Pick a habitat: ");
        return _habitat = method.InputRead(data.habitat, 0);
    }


    public override string Breed()
    { 
        bool repeat = false;
        bool repeat1 = false;
        string choice;
        do{ 
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
                                        return _breed = data.cretaceousBreeds[2];
                                    case "2":  
                                        return _breed = data.cretaceousBreeds[5];
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
                            }while(repeat1);
                            break;
                        default:
                            Console.Clear();
                            repeat = true;
                            break;
                    }
        }while (repeat);

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
       return  this._skinColor1 = $"{color1} , {color2}";
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
        get => _name; set => _name = value;
    }
    public IEnumerable<int> TraitsAmount()
    {
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
            Console.WriteLine($"{elem.Key}: {elem.Value}");
        }
        foreach (KeyValuePair<string, int> elem in data.traits)
        {
            Console.Write($"{elem.Key}: ");
            do
            {
                try
                {
                    add = int.Parse(Console.ReadLine());
                    if (add < 0 | add > 20)
                    {
                        Console.WriteLine("You can only allocate below 20 and above 0. Try again.");
                        repeat1 = true;
                    }
                    else if (total > 41)
                    {
                        Console.Write($"You can only allocate 40 points, Your remaining points are {total - 40}. Try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Try again.");
                    repeat1 = true;
                }
                yield return data.traits[elem.Key] = data.traits[elem.Key] + add;
            }while (repeat1) ;  
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
        }while (repeat);

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
        }while (repeat); 
        return false;
    }
}