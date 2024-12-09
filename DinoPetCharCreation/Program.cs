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
            Dinosaur dino = new Dinosaur();
            Start:
            switch (func.DisplayNReadMethod(data.menu, "Welcome to DinoPetCharCreation"))
            {
                case "NEW GAME":
                    dino.Era = func.DisplayNReadMethod(data.era, "Choose an era");
                    dino.Habitat = func.DisplayNReadMethod(data.habitat, "Choose a habitat for you dinosaur"); 
                    dino.Breed = func.DisplayNReadMethod(data.breed, dino.Era, dino.Habitat, "Choose a dinosaur breed"); 
                    dino.FavoriteFood = func.FavoriteFoodGet(data.favoritefood,dino.Breed);
                    dino.Gender = func.DisplayNReadMethod(data.gender, "Choose a gender for you dinosaur");
                    dino.Nature = func.DisplayNReadMethod(data.nature, "Choose a nature for you dinosaur");
                    dino.SkinColor = func.DisplayNReadMethod(data.skincolor, "Choose a skin color");
                    dino.SkinPattern = func.DisplayNReadMethod(data.skinpattern, "Choose a skin pattern");
                    dino.SkinTexture = func.DisplayNReadMethod(data.skintexture, "Choose a skintexture");
                    dino.BodyFeatures = func.DisplayNReadMethod(data.bodyfeatures, "Choose a body feature");
                    dino.FacialFeatures = func.DisplayNReadMethod(data.facialfeatures, "Choose a facial feature");
                    dino.TailType = func.DisplayNReadMethod(data.tailtype, "Choose a tail type");
                    dino.Behavior = func.DisplayNReadMethod(data.behavior, "Choose a behavior");
                    dino.Name = func.NameCheck("Name your dinosaur");
                    dino.TraitsAmount();
                    Build:
                    Console.Write("Do you wish to build this dinosaur?(yes/no): ");
                    string choice = Console.ReadLine().ToLower();
                    if ( choice == "yes")
                    {
                        dino.BuildDinosaur();
                    }
                    else if (choice == "no")
                    {
                        goto Start;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                        goto Build;
                    }
                    break;
                case "LOAD GAME":
                    break;
                case "CAMPAIGN MODE":
                    func.showgamestory();
                    goto Start;
                case "CREDITS":
                    func.showcredits();
                    goto Start;
                case "EXIT":
                    Console.WriteLine("Successfully exited DinoPetCharCreation");
                    break;
            }

        }
    }
}
        