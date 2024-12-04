using System;
using System.Text;
using System.Xml.XPath;

namespace DinoPetCharCreation
{
    public class Menu
    {
        static Methods func = new Methods();

        public static void Main()
        {
            DataArray data = new DataArray();
            Console.WriteLine("Welcome to DinoPetCharCreation");
            Console.WriteLine("Do you wish to skip the story? (y/n)");
            if (Console.ReadLine().ToLower() == "n")
            {
                func.showGameStory();
            }

            Console.Write("Pick an era: ");
            string era = func.InputRead(data.era, 0);
            string dinosaurBreed = func.PickDinosaur(era);
            func.DisplayMethod(data.gender);
            string gender = func.InputRead(data.gender, 0);
            func.DisplayMethod(data.nature);
            Console.Write("Pick a nature: ");
            string nature = func.InputRead(data.nature, 0);
            func.DisplayMethod(data.skinColor);
            Console.Write("Pick a skin color: ");
            string skinColor = func.InputRead(data.skinColor, 0);
            func.DisplayMethod(data.skinPattern);
            Console.Write("Pick a skin pattern: ");
            string skinPattern = func.InputRead(data.skinPattern, 0);
            // FavoriteFood randomizer
            func.DisplayMethod(data.skinTexture);
            Console.Write("Pick a skin texture: ");
            string skinTexture = func.InputRead(data.skinTexture, 0);
            func.DisplayMethod(data.bodyFeatures);
            Console.Write("Pick a body feature: ");
            string bodyFeatures = func.InputRead(data.bodyFeatures, 0);
            func.DisplayMethod(data.facialFeatures);
            Console.Write("Pick a facial feature: ");
            string facialFeatures = func.InputRead(data.facialFeatures, 0);
            func.DisplayMethod(data.tailType);
            Console.Write("Pick a tail type: ");
            string tailType = func.InputRead(data.tailType, 0);
            func.DisplayMethod(data.behavior);
            Console.Write("Pick a behavior: ");
            string behavior = func.InputRead(data.behavior, 0);



        }
    }
}
        