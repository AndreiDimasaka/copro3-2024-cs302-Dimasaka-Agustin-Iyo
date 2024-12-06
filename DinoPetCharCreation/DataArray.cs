namespace DinoPetCharCreation;

public struct DataArray
{
    internal string[] era = {"Triassic", "Jurassic", "Cretaceous"};
    internal  string[] habitat = { "Ocean", "Forest", "Arid", "Mountains", "Beach" };
    internal  string[] triassicBreeds = {"Eoraptor", "Herrerasaurus", "Plateosaurus", "Ichthyosaurus", "Pterosaurus"};
    internal  string[] jurassicBreeds = {"Brachiosaurus", "Pterodactyl", "Herrerasaurus", "Stegosaurus"};
    internal  string[] cretaceousBreeds = {"Triceratops", "Tyrannosaurus", "Brachiosaurus", "Pterodactyl", "Tylosaurus", "Oviraptor", "Troodon", "Ankylosaurus"};
    internal  string[] gender = { "Male", "Female" };
    internal  string[] nature = { "Aggressive", "Workaholic", "Guardian", "Traveler", "Commander" };
    internal  string[] skinColor = { "Gray", "Brown", "Red", "Black", "Blue" };
    internal  string[] skinPattern = {"Spotted", "Stripped", "Solid" };
    internal  string[] favoriteFood = { "Meat", "Plants", "Fish", "Fruits", "Eggs" };
    internal  string[] skinTexture = { "Feathered", "Rugged", "Scaly", "Smooth", "Fur" };
    internal  string[] bodyFeatures = { "Armored", "Spiked", "Spined", "Normal" };
    internal  string[] facialFeatures = { "Beak", "Horns", "Frills", "Sharp Teeth", "Spikes", "Flat Teeth"};
    internal  string[] tailType = {"Spiked", "Clubbed", "Long", "Normal", "Short" };
    internal  string[] behavior = { "Hunter", "Defender", "Worker", "Scout", "Leader" };
    internal Dictionary<string, int> traits = new Dictionary<string, int>();
    public DataArray()
    {
    }
}