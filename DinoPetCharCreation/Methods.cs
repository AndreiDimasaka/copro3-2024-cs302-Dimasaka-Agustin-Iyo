using System.Text;
using System.Text.RegularExpressions;

namespace DinoPetCharCreation;

public class Methods
{
    static StringBuilder sb = new StringBuilder();
    public string DisplayNReadMethod(Dictionary<int, string> dict, string edit)
        {
            Console.Clear();
            Console.WriteLine(edit);
            sb.Clear();
            Console.WriteLine(sb.Append('-', 32));
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine($"[{kvp.Key}]: {kvp.Value}");
            }
            bool error = false;
            do
            {
                try
                {
                    Console.Write("Choose an option: ");
                    dict.TryGetValue(int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()), out var value);
                    return value ?? throw new InvalidOperationException();
                }
                catch (IndexOutOfRangeException e)

                {
                    Console.WriteLine("Invalid input. Try again.");
                    error = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid input. Try again.");
                    error = true;
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("Invalid input. Try again.");
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
        return DisplayNReadMethod(dinos, modify);
    }

    public string NameCheck(string modify)
    {
        Console.Clear();
        bool repeat = false;
        Regex rg = new Regex(@"^[a-zA-Z0-9]{6,20}$");
        do
        {
            try
            {
                Console.Write($"{modify}: ");
                string name = Console.ReadLine() ?? throw new InvalidOperationException();
                if (rg.IsMatch(name))
                {
                    return name;
                }
                else
                {
                    Console.WriteLine("Minimum of 6 characters and maximum of 20 characters. Letters and Numbers only");
                    repeat = true;
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Invalid input. Try again.");
                repeat = true;
            }
        }while (repeat);

        return "";
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
            
            Console.WriteLine($"           Credits" +
                              $"\nDocumentation   Don Isaac Agustin" +
                              $"\nCoderist        Andrei Dimasaka" +
                              $"\nMoral Support   Angelo Iyo");
        }
    }
