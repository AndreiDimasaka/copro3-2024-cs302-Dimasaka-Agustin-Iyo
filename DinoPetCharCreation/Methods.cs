using System.Text;

namespace DinoPetCharCreation;

public class Methods
{
    static StringBuilder sb = new StringBuilder();
    public void DisplayMethod(string[] arr)
        {
            Console.WriteLine();
            Console.WriteLine("Choose the corresponding number");
            sb.Clear();
            Console.WriteLine(sb.Append('-', 32));
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{arr[i]}");
            }
        }

        public string InputRead(string[] arr, int modify)
        {
            bool error = false;
            do
            {
                try
                {
                    string result = arr[int.Parse(Console.ReadLine()) - 1 + modify];
                    return result;
                }
                catch (IndexOutOfRangeException e)

                {
                    Console.WriteLine("Invalid input. Try again.");
                    Console.Write("Answer: ");
                    error = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid input. Try again.");
                    Console.Write("Answer: ");
                    error = true;
                }
            }while (error);

            return null;
        }

        public void showGameStory()
        {
            Console.Clear();
            Console.WriteLine("In a world where mysteries lie in every corner of the land, civilization drastically " +
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

        public void showCredits()
        {
            Console.WriteLine($"Documentation   Don Isaac Agustin" +
                              $"\nCoderist      Andrei Dimasaka" +
                              $"\nMoral Support Angelo Iyo");
        }
    }
