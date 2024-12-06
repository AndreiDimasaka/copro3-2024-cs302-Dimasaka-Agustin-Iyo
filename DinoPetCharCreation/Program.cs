using System;
using System.Drawing;
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
            Console.WriteLine("Welcome to DinoPetCharCreation");
            Console.WriteLine("Do you wish to skip the story? Type 'n'");
            if (Console.ReadLine().ToLower() != "n")
            {
                func.showGameStory();
            }
            Start:
            func.DisplayMethod(data.era);
            Console.Write("Choose an era: ");
            string era = func.InputRead(data.era, 0);
            TriassicDino triassicdino = new TriassicDino();
            JurassicDino jurassicdino = new JurassicDino();
            CretaceousDino cretaceousdino = new CretaceousDino();
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
                    Color: 
                    Console.Write("Do you wish to add another color to your dinosaur? (y/n): ");
                    string choice = Console.ReadLine();
                    if (choice.ToLower() == "y")
                    {
                        Console.Write("Choose a color:");
                        string color2 = func.InputRead(data.skinColor, 0);
                        triassicdino.SkinColor(color1, color2);
                    }
                    else if (choice.ToLower() == "n")
                    {
                        triassicdino.SkinColor(color1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again.");
                        goto Color;
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
                    Build:
                    Console.Write("Build this dinosaur? (y/n): ");
                    string build_choice =  Console.ReadLine();
                    if (build_choice.ToLower() == "y")
                    {
                        triassicdino.BuildDinosaur();
                    }
                    else if (build_choice.ToLower() == "n")
                    {
                        goto Start;
                    }
                    else
                    {
                        goto Build;
                    }
                    break;
                
                case "Jurassic":
                    jurassicdino.Era = era;
                    jurassicdino.Habitat();
                    jurassicdino.Breed();
                    jurassicdino.Behavior();
                    jurassicdino.Gender();
                    jurassicdino.Nature();
                    func.DisplayMethod(data.skinColor);
                    Console.Write("Choose a color:");
                    color1 = func.InputRead(data.skinColor, 0);
                    jColor: 
                    Console.Write("Do you wish to add another color to your dinosaur? (y/n): ");
                    choice = Console.ReadLine();
                    if (choice.ToLower() == "y")
                    {
                        Console.Write("Choose a color:");
                        string color2 = func.InputRead(data.skinColor, 0);
                        jurassicdino.SkinColor(color1, color2);
                    }
                    else if (choice.ToLower() == "n")
                    {
                        jurassicdino.SkinColor(color1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again.");
                        goto jColor;
                    }
                    
                    jurassicdino.SkinPattern();
                    jurassicdino.FavoriteFood();
                    jurassicdino.SkinTexture();
                    jurassicdino.BodyFeatures();
                    jurassicdino.FacialFeatures();
                    jurassicdino.TailType();
                    jurassicdino.Behavior();
                    jurassicdino.TraitsAmount();
                    Console.Write("Enter a name for your dinosaur: ");
                    jurassicdino.Name = Console.ReadLine();
                    jBuild:
                    Console.Write("Build this dinosaur? (y/n): ");
                    build_choice =  Console.ReadLine();
                    if (build_choice.ToLower() == "y")
                    {
                        jurassicdino.BuildDinosaur();
                        foreach (KeyValuePair<string, int> elem in data.traits)
                        {
                            Console.WriteLine($"{elem.Key}: {elem.Value}");
                        }
                    }
                    else if (build_choice.ToLower() == "n")
                    {
                        goto Start;
                    }
                    else
                    {
                        goto jBuild;
                    }
                    break;
                case "Cretaceous":
                    cretaceousdino.Era = era;
                    cretaceousdino.Habitat();
                    cretaceousdino.Breed();
                    cretaceousdino.Behavior();
                    cretaceousdino.Gender();
                    cretaceousdino.Nature();
                    func.DisplayMethod(data.skinColor);
                    Console.Write("Choose a color:");
                    color1 = func.InputRead(data.skinColor, 0);
                    cColor:  
                    Console.Write("Do you wish to add another color to your dinosaur? (y/n): ");
                    choice = Console.ReadLine();
                    if (choice.ToLower() == "y")
                    {
                        Console.Write("Choose a color:");
                        string color2 = func.InputRead(data.skinColor, 0);
                        cretaceousdino.SkinColor(color1, color2);
                    }
                    else if (choice.ToLower() == "n")
                    {
                        cretaceousdino.SkinColor(color1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again.");
                        goto cColor;
                    }
                    
                    cretaceousdino.SkinPattern();
                    cretaceousdino.FavoriteFood();
                    cretaceousdino.SkinTexture();
                    cretaceousdino.BodyFeatures();
                    cretaceousdino.FacialFeatures();
                    cretaceousdino.TailType();
                    cretaceousdino.Behavior();
                    cretaceousdino.TraitsAmount();
                    Console.Write("Enter a name for your dinosaur: ");
                    cretaceousdino.Name = Console.ReadLine();
                    cBuild:
                    Console.Write("Build this dinosaur? (y/n): ");
                    build_choice =  Console.ReadLine();
                    if (build_choice.ToLower() == "y")
                    {
                        cretaceousdino.BuildDinosaur();
                        foreach (KeyValuePair<string, int> elem in data.traits)
                        {
                            Console.WriteLine($"{elem.Key}: {elem.Value}");
                        }
                    }
                    else if (build_choice.ToLower() == "n")
                    {
                        goto Start;
                    }
                    else
                    {
                        goto cBuild;
                    }
                    break;
            }
            }


        }
    }
        