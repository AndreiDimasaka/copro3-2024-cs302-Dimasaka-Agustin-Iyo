namespace DinoPetCharCreation;

public struct DataArray
{
    internal Dictionary<int, string> menu = new Dictionary<int, string>()
    {
        { 1, "NEW GAME" },
        { 2, "LOAD GAME" },
        { 3, "CAMPAIGN MODE" },
        { 4, "CREDITS" },
        { 5, "EXIT" }
    };
    internal Dictionary<int, string> era = new Dictionary<int, string>()
    {
        { 1, "TRIASSIC" },
        { 2, "JURASSIC" },
        { 3, "CRETACEOUS" },
    };
    internal Dictionary<int, string> habitat = new Dictionary<int, string>()
    {
        { 1, "OCEAN" },
        { 2, "FOREST" },
        { 3, "ARID" },
        { 4, "MOUNTAINS" },
        { 5, "BEACH" }
    };

    internal Dictionary<string, List<(string habitat, string dinosaurType)>> breed = new Dictionary<string, List<(string, string)>>()
    {
        { "TRIASSIC", new List<(string, string)>
            {
                ("OCEAN", "ICHTHYOSAURUS"),
                ("FOREST", "EORAPTOR"),
                ("FOREST", "PLATEOSAURUS"),
                ("ARID", "EORAPTOR"),
                ("ARID", "HERRERASAURUS"),
                ("MOUNTAINS", "HERRERASAURUS"),
                ("BEACH", "PTEROSAURUS")
            }
        },
        { "JURASSIC", new List<(string, string)>
            {
                ("OCEAN", "LORRAINOSAURUS"),
                ("FOREST", "BRACHIOSAURUS"),
                ("FOREST", "HERRERASAURUS"),
                ("FOREST", "STEGOSAURUS"),
                ("ARID", "BRACHIOSAURUS"),
                ("ARID", "HERRERASAURUS"),
                ("ARID", "STEGOSAURUS"),
                ("MOUNTAINS", "PTERODACTYL"),
                ("BEACH", "PTERODACTYL")
            }
        },
        { "CRETACEOUS", new List<(string, string)>
            {
                ("OCEAN", "TYLOSAURUS"),
                ("FOREST", "TRICERATOPS"),
                ("FOREST", "TYRANNOSAURUS"),
                ("FOREST", "BRACHIOSAURUS"),
                ("FOREST", "OVIRAPTOR"),
                ("FOREST", "TROODON"),
                ("FOREST", "ANKYLOSAURUS"),
                ("ARID", "BRACHIOSAURUS"),
                ("ARID", "OVIRAPTOR"),
                ("MOUNTAINS", "TRICERATOPS"),
                ("MOUNTAINS", "TYRANNOSAURUS"),
                ("MOUNTAINS", "PTERODACTYL"),
                ("BEACH", "PTERODACTYL"),
                ("BEACH", "TROODON"),
                ("BEACH", "ANKYLOSAURUS")
            }
        }
    };
    internal Dictionary<int, string> gender = new Dictionary<int, string>()
    {
        { 1, "MALE" },
        { 2, "FEMALE" },
    };
    internal Dictionary<int, string> nature = new Dictionary<int, string>()
    {
        { 1, "AGGRESSIVE" },
        { 2, "WORKAHOLIC" },
        { 3, "GUARDIAN" },
        { 4, "TRAVELER" },
        { 5, "COMMANDER" }
    };
    internal Dictionary<int, string> skincolor = new Dictionary<int, string>()
    {
        { 1, "BLACK" },
        { 2, "BROWN" },
        { 3, "RED" },
        { 4, "GRAY" },
        { 5, "BLUE" }
    };
    internal Dictionary<int, string> skinpattern = new Dictionary<int, string>()
    {
        { 1, "SPOTTED" },
        { 2, "STRIPPED" },
        { 3, "SOLID" },
    };
    internal Dictionary<int, string> skintexture = new Dictionary<int, string>()
    {
        { 1, "FEATHERED" },
        { 2, "RUGGED" },
        { 3, "SCALY" },
        { 4, "SMOOTH" },
        { 5, "FUR" }
    };
    internal Dictionary<int, string> bodyfeatures = new Dictionary<int, string>()
    {
        { 1, "ARMORED" },
        { 2, "SPIKED" },
        { 3, "SPINED" },
        { 4, "NORMAL" },
    };
    internal Dictionary<int, string> facialfeatures = new Dictionary<int, string>()
    {
        { 1, "BEAK" },
        { 2, "HORNS" },
        { 3, "FRILLS" },
        { 4, "SPIKES" },
        { 5, "FLAT TEETH" },
        { 6, "SHARP TEETH" }
    };
    internal Dictionary<int, string> tailtype = new Dictionary<int, string>()
    {
        { 1, "SPIKED" },
        { 2, "CLUBBED" },
        { 3, "LONG" },
        { 4, "NORMAL" },
        { 5, "SHORT"}
    };
    internal Dictionary<int, string> behavior = new Dictionary<int, string>()
    {
        { 1, "HUNTER" },
        { 2, "DEFENDER" },
        { 3, "WORKER" },
        { 4, "SCOUT" },
        { 5, "LEADER"}
    };

    internal Dictionary<string, string> favoritefood = new Dictionary<string, string>()
    {
        { "TRICERATOPS", "PLANTS" },
        { "TYRANNOSAURUS", "MEAT" },
        { "BRACHIOSAURUS", "PLANTS" },
        { "PTERODACTYL", "FISH" },
        {"PTEROSAURUS", "FISH"} ,
        { "TYLOSAURUS", "FISH" },
        { "OVIRAPTOR", "EGGS" },
        { "TROODON", "MEAT" },
        { "ANKYLOSAURUS", "PLANTS" },
        { "EORAPTOR", "FRUITS" },
        { "HERRERASAURUS", "MEAT" },
        { "PLATEOSAURUS", "PLANTS" },
        { "ICHTHYOSAURUS", "FISH" },
        {"LORRAINOSAURUS", "FISH"},
        {"STEGOSAURUS", "PLANTS"}
    };
    public DataArray()
    {
    }
}