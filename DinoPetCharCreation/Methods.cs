using System.Text;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace DinoPetCharCreation;

public class Methods
{
    
    static StringBuilder sb = new StringBuilder();
    public string DisplayNReadMethod(Dictionary<int, string> dict, string edit, bool clear)
    {
        bool error = false;
            do{ 
                error = false;
            
            if (clear)
            {
                Console.Clear();
            }
            Console.WriteLine(edit);
            sb.Clear();
            Console.WriteLine(sb.Append('-', 32));
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine($"[{kvp.Key}]: {kvp.Value}");
            }
            try
            {
                    Console.Write("Choose an option: ");
                    dict.TryGetValue(int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()), out var value);
                    return value ?? throw new InvalidOperationException();
            }
            catch (IndexOutOfRangeException e)

            {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Try again.");
                    CodeEnd();
                    error = true;
            }
            catch (FormatException e)
            {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Try again.");
                    CodeEnd();
                    error = true;
            }
            catch (InvalidOperationException e)
            {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Try again.");
                    CodeEnd();
                    error = true;
            }
            }while (error);

            return "";
        }
    public string DisplayNReadMethod(Dictionary<int, string> dict, string edit, bool clear, int line)
    {
        bool error = false;
        do{ 
            error = false;
            
            if (clear)
            {
                Console.Clear();
            }
            Console.WriteLine(edit);
            sb.Clear();
            Console.WriteLine(sb.Append('-', line));
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine($"[{kvp.Key}]: {kvp.Value}");
            }
            try
            {
                Console.Write("Choose an option: ");
                dict.TryGetValue(int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()), out var value);
                return value ?? throw new InvalidOperationException();
            }
            catch (IndexOutOfRangeException e)

            {
                Console.Clear();
                Console.WriteLine("Invalid input. Try again.");
                CodeEnd();
                error = true;
            }
            catch (FormatException e)
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Try again.");
                CodeEnd();
                error = true;
            }
            catch (InvalidOperationException e)
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Try again.");
                CodeEnd();
                error = true;
            }
        }while (error);

        return "";
    }

    public string DisplayNReadMethod( Dictionary<string, List<(string habitat, string dinosaurType)>> dict, string era, string habitat, string modify)
    {
        Dictionary<int, string> dinos = new Dictionary<int, string>();
        int number = 1;
        var eraCheck = dict[era];
        foreach (var (environment, breed) in eraCheck)
        {
            if (environment == habitat)
            {
                dinos.Add(number, breed);
                number++;
            }
        }
        return DisplayNReadMethod(dinos, modify, true);
    }

    public string NameCheck(string modify)
    {
        Console.Clear();
        bool repeat = false;
        string dino_name = "";
        Regex rg = new Regex(@"^[a-zA-Z0-9]{6,20}$");
        string connectorString =
            "server= localhost; database = charcreation; user id = root; password = 1234; SslMode = None;";
        using (var connection = new MySqlConnection(connectorString))
        {
            connection.Open();
            string query = "SELECT Name FROM Dinosaur";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            do
            {
                try
                {
                    repeat = false;
                    Console.Write($"{modify}: ");
                    dino_name = Console.ReadLine();
                    MySqlDataReader reader = command.ExecuteReader();
                    if (rg.IsMatch(dino_name))
                    {
                        while (reader.Read())
                        {
                            string saved_name = reader.GetString(0);
                            if (saved_name.Equals(dino_name, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Name already taken. Try again.");
                                repeat = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Minimum of 6 characters and maximum of 20 characters. Letters and Numbers only");
                        repeat = true;
                    }
                    reader.Close();
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("Invalid input. Try again.");
                    repeat = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured" + e.Message);
                    repeat = true;
                }

            } while (repeat) ;
        } 
        return dino_name;
    }


    
    public void CodeEnd()
    {
        Console.WriteLine();
        Console.Write("Press any key to continue");
        Console.ReadKey();
        Console.Clear();
    }

    public string FavoriteFoodGet(Dictionary<string, string> dict, string breed)
    {
        foreach (KeyValuePair<string, string> kvp in dict)
        {
            if (kvp.Key == breed)
            {
                return kvp.Value;
            }
        }
        return "";
    }

    public void ShowAllCharacters()
    {
        string connectorString =
            "server= localhost; database = charcreation; user id = root; password = 1234; SslMode = REQUIRED;";
        try
        {
            using (var connection = new MySqlConnection(connectorString))
            {
                int x = 0, y = 2;
                connection.Open();
                string query = "SELECT * FROM Dinosaur";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write($"{reader.GetName(i)}");
                    Console.SetCursorPosition(x + 20, y);
                    Console.WriteLine($" {reader.GetValue(i)}");
                    y++;
                }

                while (reader.Read())
                {
                    x += 20;
                    y = 2;
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.SetCursorPosition(x + 20, y);
                        Console.WriteLine($"{reader.GetValue(i)}");
                        y++;
                    }
                }
                reader.Close();
                connection.Close();
            }
        }
        catch (MySqlException e)
        {
            Console.WriteLine(e);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }

    public void showgamestory()
        {
            Console.Clear();
            TypeWriter("In a world where mysteries lie in every corner of the land, civilization drastically " +
            "changed when ancient ruins, forgotten in time, towered before humanity. Strange structures " +
            "began to rise as tremors shook the earth, unearthing secrets buried deep underground. " +
            "These are later named \"Monoliths,\" structures left behind by an ancient civilization " +
            "that once coexisted with dinosaurs. As light poured out of them, creatures once thought " +
            "to be extinct began to emerge from their deep slumber. Dinosaurs, terrifying beings that " +
            "once ruled the land, the seas, and the sky. These events would be recorded as \"The Fracture,\" " +
            "a pivotal point that would shape history.\n\n" +
            "Numerous attempts were made to decipher the archaic records found inside the Monoliths, " +
            "most of which ended in failure. Exploring the Monoliths also took great risk, and almost " +
            "20 years passed before a breakthrough was made. Devices that allowed humans to commune " +
            "with dinosaurs were discovered deep inside the ancient ruins. At their core were link stones, " +
            "the missing piece of the puzzle. They are fragments from an ore deposit that glowed intensely when subjected to heat and pressure. " +
            "\n\nThe link stones, believed to be the catalyst behind the revival of the dinosaurs, " +
            "also allowed humanity to establish a bond with them. " +
            "It proved that coexistence was possible, and now they are dependable companions. " +
            "The Monoliths, still shrouded in mystery, are now braved by humans and dinosaurs together. " +
            "\"Relic hunters,\" as they are called, now explore these ancient ruins to uncover the secrets of a bygone era. " +
            "These explorers challenge the unknown in the hopes of finding fame, fortune, or maybe even the truth.");
        }

        public void TypeWriter(string text, int delay = 30)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        public void showcredits()
        {
            Console.Clear();
            Console.WriteLine($"           Credits" +
                              $"\nBATTLE HARDENED   Don Isaac Agustin" +
                              $"\nCHILL GUY         Andrei Dimasaka" +
                              $"\nRESIDENT SLEEPER  Angelo Iyo");
        }
    }
