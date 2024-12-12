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
            switch (func.DisplayNReadMethod(data.menu, "Welcome to DinoPetCharCreation"))
            {
                case "NEW GAME":
                    dino.Era = func.DisplayNReadMethod(data.era, "Choose an era");
                    dino.Habitat = func.DisplayNReadMethod(data.habitat, "Choose a habitat for you dinosaur");
                    dino.Breed = func.DisplayNReadMethod(data.breed, dino.Era, dino.Habitat, "Choose a dinosaur breed");
                    dino.FavoriteFood = func.FavoriteFoodGet(data.favoritefood, dino.Breed);
                    dino.Gender = func.DisplayNReadMethod(data.gender, "Choose a gender for you dinosaur");
                    dino.Nature = func.DisplayNReadMethod(data.nature, "Choose a nature for you dinosaur");
                    dino.SkinColor = func.DisplayNReadMethod(data.skincolor, "Choose a skin color");
                    dino.SkinPattern = func.DisplayNReadMethod(data.skinpattern, "Choose a skin pattern");
                    dino.SkinTexture = func.DisplayNReadMethod(data.skintexture, "Choose a skintexture");
                    dino.BodyFeatures = func.DisplayNReadMethod(data.bodyfeatures, "Choose a body feature");
                    dino.ExtraFeature();
                    dino.FacialFeatures = func.DisplayNReadMethod(data.facialfeatures, "Choose a facial feature");
                    dino.TailType = func.DisplayNReadMethod(data.tailtype, "Choose a tail type");
                    dino.Behavior = func.DisplayNReadMethod(data.behavior, "Choose a behavior");
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
                                    "INSERT INTO Dinosaur(Name, era, habitat, breed, FavoriteFood, Gender, Nature, SkinColor, SkinPattern, SkinTexture, BodyFeatures, ExtraFeatures, FacialFeatures, TailType, Behavior, Speed, Strength, Intelligence, Dexterity, Toughness) VALUES ('" +
                                    dino.Name + "', '" + dino.Era + "', '" + dino.Habitat + "', '" + dino.Breed +
                                    "', '" + dino.FavoriteFood + "', '" + dino.Gender + "', '" + dino.Nature + "', '" +
                                    dino.SkinColor + "', '" + dino.SkinPattern + "', '" + dino.SkinTexture + "', '" +
                                    dino.BodyFeatures + "','" + dino.ExtraFeatures + "' ,'" + dino.FacialFeatures +
                                    "', '" + dino.TailType + "', '" + dino.Behavior + "','" + dino.Speed + "', '" +
                                    dino.Strength + "','" + dino.Intelligence + "','" + dino.Dexterity + "','" + dino.Toughness + "' )";
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
                            Console.Clear();
                            connection.Open();
                            Dictionary<int, string> dino_save = new Dictionary<int, string>();
                            string query = "SELECT * FROM Dinosaur";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            MySqlDataReader reader = command.ExecuteReader();
                            while(reader.Read())
                            {
                                dino_save.Add(dino_save.Count + 1, reader.GetString(0));
                            }
                            reader.Close();
                            bool repeat = false;
                            do
                            {
                                repeat = false;
                                string name = func.DisplayNReadMethod(dino_save, "Saved Dinosaur");
                                Console.Write("Do you wish to select or delete this dinosaur?(select/delete): ");
                                string select_delete = Console.ReadLine().ToLower();
                                if (select_delete == "select")
                                {
                                    query = "SELECT * FROM Dinosaur WHERE Name = '" + name + "'";
                                    command = new MySqlCommand(query, connection);
                                    command.ExecuteNonQuery();
                                    reader = command.ExecuteReader();
                                    reader.Read();
                                    Console.Clear();
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        Console.WriteLine($"{reader.GetName(i)}: {reader.GetValue(i)}");
                                    }
                                    reader.Close();
                                    connection.Close();
                                    func.CodeEnd();
                                    goto Start;
                                }
                                else if (select_delete == "delete")
                                {
                                    query = "DELETE FROM Dinosaur WHERE Name = '" + name + "'";
                                    command = new MySqlCommand(query, connection);
                                    command.ExecuteNonQuery();
                                    Console.WriteLine("Successfully deleted dinosaur");
                                    connection.Close();
                                    func.CodeEnd();
                                    goto Start;
                                }
                                else
                                {
                                    Console.WriteLine("Wrong input");
                                    repeat = true;
                                }
                            } while (repeat);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("An error occured" + ex.Message);
                        }
                    }
                    goto Start;
                case "CAMPAIGN MODE":
                    func.showgamestory();
                    func.CodeEnd();
                    goto Start;
                case "CREDITS":
                    func.showcredits();
                    func.CodeEnd();
                    goto Start;
                case "EXIT":
                    Console.WriteLine("Successfully exited DinoPetCharCreation");
                    break;
            }
        }
    }
}
        