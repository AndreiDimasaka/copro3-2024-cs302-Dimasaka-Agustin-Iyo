using System;
using System.Drawing;
using System.Text;
using System.Xml.XPath;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DinoPetCharCreation
{
    public class Menu
    {

        public static void Main()
        {
            DataArray data = new DataArray();
            Methods func = new Methods();
            Dinosaur dino = new Dinosaur();
            StringBuilder sb = new StringBuilder();
            Start:
            switch (func.DisplayNReadMethod(data.menu, "Welcome to DinoPetCharCreation", true))
            {
                case "NEW GAME":
                    dino.Era = func.DisplayNReadMethod(data.era, "Choose an era", true);
                    dino.Habitat = func.DisplayNReadMethod(data.habitat, "Choose a habitat for you dinosaur", true);
                    dino.Breed = func.DisplayNReadMethod(data.breed, dino.Era, dino.Habitat, "Choose a dinosaur breed");
                    dino.FavoriteFood = func.FavoriteFoodGet(data.favoritefood, dino.Breed);
                    dino.Gender = func.DisplayNReadMethod(data.gender, "Choose a gender for you dinosaur", true);
                    dino.Nature = func.DisplayNReadMethod(data.nature, "Choose a nature for you dinosaur", true);
                    dino.SkinColor = func.DisplayNReadMethod(data.skincolor, "Choose a skin color", true);
                    dino.SkinPattern = func.DisplayNReadMethod(data.skinpattern, "Choose a skin pattern", true);
                    dino.SkinTexture = func.DisplayNReadMethod(data.skintexture, "Choose a skintexture", true);
                    dino.BodyFeatures = func.DisplayNReadMethod(data.bodyfeatures, "Choose a body feature", true);
                    dino.ExtraFeature();
                    dino.FacialFeatures = func.DisplayNReadMethod(data.facialfeatures, "Choose a facial feature", true);
                    dino.TailType = func.DisplayNReadMethod(data.tailtype, "Choose a tail type", true);
                    dino.Behavior = func.DisplayNReadMethod(data.behavior, "Choose a behavior", true);
                    dino.Name = func.NameCheck("Name your dinosaur");
                    dino.TraitsAmount();
                    Build:
                    Console.Clear();
                    Console.Write("Do you wish to build this dinosaur?(yes/no): ");
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "yes")
                    {
                        dino.BuildDinosaur();
                        string connectionString =
                            "server= localhost; database = charcreation; user id = root; password = 1234; SslMode = none;";
                        using (var connection = new MySqlConnection(connectionString))
                        {
                            try
                            {
                                connection.Open();
                                string query =
                                    "INSERT INTO Dinosaur(Name, Era, Habitat, Breed, FavFood, Gender, Nature, Color,Pattern,Texture, BodyFeatures, ExtraFeatures, FaceFeatures, Tail, Behavior, Speed, Strength, Intelligence, Dexterity, Toughness, Wing, Fins, Claw) VALUES ('" +
                                    dino.Name + "', '" + dino.Era + "', '" + dino.Habitat + "', '" + dino.Breed +
                                    "', '" + dino.FavoriteFood + "', '" + dino.Gender + "', '" + dino.Nature + "', '" +
                                    dino.SkinColor + "', '" + dino.SkinPattern + "', '" + dino.SkinTexture + "', '" +
                                    dino.BodyFeatures + "','" + dino.ExtraFeatures + "' ,'" + dino.FacialFeatures +
                                    "', '" + dino.TailType + "', '" + dino.Behavior + "', " + dino.Speed + ", " +
                                    dino.Strength + "," + dino.Intelligence + "," + dino.Dexterity + ",'" + dino.Toughness + "', "+dino.Wing+", "+dino.Fins+", "+dino.Claw+")";
                                MySqlCommand command = new MySqlCommand(query, connection);
                                command.ExecuteNonQuery();
                                connection.Close();
                                func.CodeEnd();
                                goto Start;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("An error occured" + ex.Message);
                            }
                        }
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
                    string connectorString =
                        "server= localhost; database = charcreation; user id = root; password = 1234; SslMode = REQUIRED;";
                    using (var connection = new MySqlConnection(connectorString))
                    {
                        try
                        {
                            Menu:
                            connection.Open();
                            Dictionary<int, string> dino_save = new Dictionary<int, string>()
                            {
                                { 0, "EXIT" }
                            };
                            string query = "SELECT * FROM Dinosaur";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            MySqlDataReader reader = command.ExecuteReader();
                            while(reader.Read())
                            {
                                dino_save.Add(dino_save.Count, reader.GetString(0));
                            }
                            reader.Close();
                            if (dino_save.Count == 0)
                            {
                                Console.WriteLine("No dinosaurs loaded");
                                func.CodeEnd();
                                goto Start;
                            }
                            switch (func.DisplayNReadMethod(data.loadmenu, "Character Menu", true))
                            {
                                case "VIEW ALL CHARACTERS":
                                    Console.Clear();
                                    Console.WriteLine("Saved Dinosaurs");
                                    sb.Clear();
                                    Console.WriteLine(sb.Append('-', 200));
                                    func.ShowAllCharacters();
                                    sb.Clear();
                                    Console.WriteLine(sb.Append('-', 200));
                                    func.CodeEnd();
                                    connection.Close();
                                    goto Menu;
                                case "VIEW A SPECIFIC CHARACTER":
                                    int x = 0, y = 0;
                                    string name = func.DisplayNReadMethod(dino_save, "Saved Dinosaurs", true);
                                    if (name == "EXIT")
                                    {
                                        reader.Close();
                                        connection.Close();
                                        goto Menu;
                                    }
                                    query = "SELECT * FROM Dinosaur WHERE Name = '" + name + "'";
                                    command = new MySqlCommand(query, connection);
                                    command.ExecuteNonQuery();
                                    reader = command.ExecuteReader();
                                    reader.Read();
                                    Console.Clear();
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        Console.Write($"{reader.GetName(i)}");
                                        Console.SetCursorPosition(x + 15, y);
                                        Console.WriteLine($"{reader.GetValue(i)}");
                                        y++;
                                    }
                                    reader.Close();
                                    connection.Close();
                                    func.CodeEnd();
                                    goto Menu;
                                case "DELETE A SPECIFIC CHARACTER":
                                    name = func.DisplayNReadMethod(dino_save, "Saved Dinosaurs", true);
                                    if (name == "EXIT")
                                    {
                                        reader.Close();
                                        connection.Close();
                                        goto Menu;
                                    }
                                    delete_build:
                                    Console.Write("Are you sure you wish to delete this dinosaur?(yes/no): ");
                                    switch (Console.ReadLine().ToLower())
                                    {
                                        case "yes":
                                            query = "DELETE FROM Dinosaur WHERE Name = '" + name + "'";
                                            command = new MySqlCommand(query, connection);
                                            command.ExecuteNonQuery();
                                            Console.WriteLine("\nSuccessfully deleted dinosaur");
                                            connection.Close();
                                            func.CodeEnd();
                                            goto Menu;
                                        case "no":
                                            connection.Close();
                                            goto Menu;
                                        default:
                                            Console.WriteLine("Wrong input");
                                            goto delete_build;
                                    }
                                case "GO BACK TO MAIN MENU":
                                     goto Start;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("An error occured" + ex.Message);
                        }
                    }
                    break;
                case "CAMPAIGN MODE":
                    func.showgamestory();
                    func.CodeEnd();
                    goto Start;
                case "CREDITS":
                    func.showcredits();
                    func.CodeEnd();
                    goto Start;
                case "EXIT":
                    Console.Clear();
                    Console.WriteLine("Successfully exited DinoPetCharCreation");
                    break;
            }
        }
    }
}
        