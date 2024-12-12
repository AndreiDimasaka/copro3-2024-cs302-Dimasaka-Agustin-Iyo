using System.Text;

namespace DinoPetCharCreation;

public class Dinosaur : DinoBuilder,DinoBuild
{
    private DataArray data = new DataArray();
    private string _era;
    private string _habitat;
    private string _breed;
    private string _gender;
    private string _nature;
    private string _skinColor;
    private string _skinPattern;
    private string _skinTexture;
    private string _favoriteFood;
    private string _bodyFeatures;
    private string _facialFeatures;
    private string _tailType;
    private string _behavior;
    private string _name;
    private string _extraFeatures;
    private int _speed;
    private int _strength;
    private int _intelligence;
    private int _dexterity;
    private int _toughness;
    private StringBuilder sb = new StringBuilder();

    public Dinosaur()
    {
        
    }
    
    public void BuildDinosaur()
    {
        ExtraFeature();
        Console.Clear();
        Console.WriteLine("Successfully Built your dinosaur");
        Console.WriteLine(
            $"\nEra: {_era}\nHabitat: {_habitat}\nBreed: {_breed}\nGender: {_gender}\nNature: {_nature}" +
            $"\nSkin Color: {_skinColor}\nSkin Pattern: {_skinPattern}\nSkin Texture: {_skinTexture}" +
            $"\nFavorite Food: {_favoriteFood}\nBody Features: {_bodyFeatures}\nFacial Features: {_facialFeatures}" +
            $"\nExtra Features:{_extraFeatures} \nTail Type: {_tailType} \nBehavior: {_behavior} \nName: {_name}");
        
        Console.WriteLine($"Stats(Spd: {_speed}, Str: {_strength}, Int: {_intelligence}, Dex: {_dexterity}, Tough: {_toughness})");
    }
    

    public override string Era{
        get => _era;
        set => _era = value; }

    public override string Habitat
    {
        get => _habitat;
        set => _habitat = value;
    }

    public override string Breed
    {
        get => _breed;
        set => _breed = value;
    }

    public override string Gender
    {
        get => _gender;
        set => _gender = value;
    }

    public override string Nature
    {
        get => _nature;
        set => _nature = value;
    }

    public override string SkinColor
    {
        get => _skinColor;
        set => _skinColor = value;
    }

    public override string SkinPattern
    {
        get => _skinPattern;
        set => _skinPattern = value;
    }

    public override string SkinTexture
    {
        get => _skinTexture;
        set => _skinTexture = value;
    }

    public override string FavoriteFood
    {
        get => _favoriteFood;
        set => _favoriteFood = value;
    }

    public override string BodyFeatures
    {
        get => _bodyFeatures;
        set => _bodyFeatures = value;
    }
    public string ExtraFeatures
    {
        get => _extraFeatures;
        set => _extraFeatures = value;
    }

    public override string FacialFeatures
    {
        get => _facialFeatures;
        set => _facialFeatures = value;
    }

    public override string TailType
    {
        get => _tailType;
        set => _tailType = value;
    }

    public override string Behavior
    {
        get => _behavior;
        set => _behavior = value;
    }

    public override string Name
    {
        get => _name;
        set => _name = value;
    }

    public int Speed
    {
        get => _speed;
        set => _speed = value;
    }
    public int Strength
    {
        get => _strength;
        set => _strength = value;
    }
    public int Intelligence
    {
        get => _intelligence;
        set => _intelligence = value;
    }
    public int Dexterity
    {
        get => _dexterity;
        set => _dexterity = value;
    }
    public int Toughness
    {
        get => _toughness;
        set => _toughness = value;
    }

    public void TraitsAmount()
    {
    Dictionary<string, int> traits = new Dictionary<string, int>()
    {
        { "Speed", 0 },
        { "Strength", 0 },
        { "Intelligence", 0 },
        { "Dexterity", 0 },
        { "Toughness", 0 }
    };
        Console.Clear();
        bool repeat1 = false;
        int add = 0;
        int total = 0;
        
        Console.WriteLine();
        Console.WriteLine("Allocate 40 points to your dinosaur stats, Max per stat is 20");
        sb.Clear();
        Console.WriteLine(sb.Append('-', 64));
        Console.WriteLine("Stats: (Speed, Strength, Intelligence, Dexterity, Toughness)");    
        foreach (KeyValuePair<string, int> elem in traits)
        {
            do
            {
                try
                {
                    repeat1 = false;
                    Console.WriteLine($"Remaining points {40 - total}");
                    Console.Write($"{elem.Key}: ");
                    add = int.Parse(Console.ReadLine());
                    if (add < 0 | add > 20)
                    {
                        Console.WriteLine("You can only allocate below 20 and above 0. Try again.");
                        repeat1 = true;
                    }
                    else if (total == 40)
                    {
                        repeat1 = false;
                    }
                    else
                    { 
                        total += add;
                        traits[elem.Key] = traits[elem.Key] + add;
                        if (total > 40)
                        {
                            total -= add;
                            repeat1 = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    total -= add;
                    Console.WriteLine("Invalid input. Try again.");
                    repeat1 = true;
                }
                catch (InvalidCastException)
                {
                    total -= add;
                    Console.WriteLine("Invalid input. Try again.");
                    repeat1 = true;
                }
            } while (repeat1);
        }
        foreach (KeyValuePair<string, int> elem2 in traits)
        {
            switch (elem2.Key)
            {
                case "Speed":
                    _speed = elem2.Value;
                    break;
                case "Strength":
                    _strength = elem2.Value;
                    break;
                case "Intelligence":
                    _intelligence = elem2.Value;
                    break;
                case "Dexterity":
                    _dexterity = elem2.Value;
                    break;
                case "Toughness":
                    _toughness = elem2.Value;
                    break;
            }
        }
    }
    public bool hasWing()
    {
            switch (this._breed)
            {
                case "PTEROSAURUS":
                    return true;
                case "PTERODACTYL":
                    return true;
                default:
                    return false;
            }
    }

    public bool hasFins()
    {
           switch (this._breed)
           {
               
               case "TYLOSAURUS":
                   return true;
               case "ICHTHYOSAURUS":
                   return true;
               case "LORRAINOSAURUS":
                   return true;
               default:
                   return false;
           }
    }

    public bool hasClaw()
    {
            switch (this._breed)
            {
                case "TRICERATOPS":
                    return true;
                case "TYRANNOSAURUS":
                    return true;
                case "BRACHIOSAURUS":
                    return true;
                case "OVIRAPTOR":
                    return true;
                case "TROODON":
                    return true;
                case "ANKYLOSAURUS":
                    return true;
                case "EORAPTOR":
                    return true;
                case "HERRERASAURUS":
                    return true;
                case "PLATEOSAURUS":
                    return true;
                default:
                    return false;
            }
    }

    public void ExtraFeature()
    {
        if (hasFins())
        {
            _extraFeatures = "FINS";
        }

        if (hasWing())
        {
            _extraFeatures = "WINGS";
        }

        if (hasClaw())
        {
            _extraFeatures = "CLAWS";
        }
    }
}