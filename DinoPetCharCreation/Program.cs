using System;
using System.Text;
using System.Xml.XPath;

namespace DinoPetCharCreation
{
    public class Menu
    {
        
        public static void Main()
        {
            DataArray data = new DataArray();
            Methods func = new Methods();
            TriassicDino triassicdino = new TriassicDino();
            Console.WriteLine("Welcome to DinoPetCharCreation");
            Console.WriteLine("Do you wish to skip the story? (y/n)");
            if (Console.ReadLine().ToLower() == "n")
            {
                func.showGameStory();
            }
            Start:
            func.DisplayMethod(data.era);
            Console.Write("Choose an era: ");
            string era = func.InputRead(data.era, 0);
            switch (era)
            {
                case "Triassic":
                    triassicdino.Era = era;
                    triassicdino.Habitat();
                    triassicdino.Breed();
                    triassicdino.Behavior();
                    triassicdino.Gender();
                    triassicdino.Nature();
                    func.DisplayMethod(data.skinColor);
                    Console.Write("Choose a color:");
                    string color1 = func.InputRead(data.skinColor, 0);
                    Console.Write("Do you wish to add another color to your dinosaur? (y/n): ");
                    string choice = Console.ReadLine();
                    if (choice.ToLower() == "y")
                    {
                        Console.Write("Choose a color:");
                        string color2 = func.InputRead(data.skinColor, 0);
                        triassicdino.SkinColor(color1, color2);
                    }
                    else
                    {
                        triassicdino.SkinColor(color1);
                    }
                    
                    triassicdino.SkinPattern();
                    triassicdino.FavoriteFood();
                    triassicdino.SkinTexture();
                    triassicdino.BodyFeatures();
                    triassicdino.FacialFeatures();
                    triassicdino.TailType();
                    triassicdino.Behavior();
                    triassicdino.TraitsAmount();
                    Console.Write("Enter a name for your dinosaur: ");
                    triassicdino.Name = Console.ReadLine();
                    Console.Write("Build this dinosaur? (y/n): ");
                    string build_choice =  Console.ReadLine();
                    if (build_choice.ToLower() == "y")
                    {
                        triassicdino.BuildDinosaur();
                        foreach (KeyValuePair<string, int> elem in data.traits)
                        {
                            Console.WriteLine($"{elem.Key}: {elem.Value}");
                        }
                    }
                    else if (build_choice.ToLower() == "n")
                    {
                        goto Start;
                    }

                    break;
            }


        }
    }
}
        