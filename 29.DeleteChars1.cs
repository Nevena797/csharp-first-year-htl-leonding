using System;

namespace _29.DeleteChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText;
            string eliminatorText;
            string result = "";

            Console.WriteLine("DeleteChars");
            Console.WriteLine("===========");
            Console.WriteLine();
            Console.Write("Eingabetext: ");
            inputText = Console.ReadLine();
            Console.Write("Eliminatortext: ");
            eliminatorText = Console.ReadLine();

            for (int i = 0; i < inputText.Length; i++)
            {
                bool toBeDeleted = false;

                for (int j = 0; j < eliminatorText.Length; j++)
                {
                    if (inputText[i] == eliminatorText[j])
                    {
                        toBeDeleted = true;
                        break;
                    }
                }

                if (!toBeDeleted)
                {
                    result += inputText[i];
                }
            }

            Console.WriteLine("Ergebnis: " + result);
            Console.WriteLine("Drücken Sie eine beliebige Taste...");
            Console.ReadKey();
        }
    }
}
