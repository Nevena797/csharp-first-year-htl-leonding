namespace _28.FilterVokals1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print the program title and separator
            Console.WriteLine("Vokale aus Text extrahieren");
            Console.WriteLine("===========================");
            Console.Write("Text: ");
            string text = Console.ReadLine();

            //Keep processing inputs untill "exit" is entered
            while (text != "exit")
            {
                //Extract vowels from the input text
                string vokale = ExtrahiereVokale(text);

                //Special handling for when the user inputes quotes
                if (text == "\"\"")
                {
                    Console.WriteLine("Der Text \"\" enthält \"\" Vokale: ");
                }
                else
                {
                    // If no vowels were found,display "" instead of a number
                    if (vokale.Length == 0)
                    {
                        Console.WriteLine($"Der Text \"{text}\" enthält \"\" Vokale: ");
                    }
                    else
                    {
                        //Show the number of vowels found and the vowels themselves
                        Console.WriteLine($"Der Text \"{text}\" enthält {vokale.Length} Vokale: {vokale}");
                    }
                }
                // Prompt for the next input
                Console.WriteLine("Beenden mit Eingabetaste ...");
                text = Console.ReadLine();
            }
        }
        /// <summary>
        /// Extracts the vowels from the given text
        /// Only keeps the first occurrence of each vowel (a, e, i, o, u)
        /// Case is preserved (if the first 'a' is uppercase,it will returned as uppercase)
        /// </summary>
        /// <param name="text">Input text to extract vowels from</param>
        /// <returns>String containing only the first occurance of each vowel</returns>
        static string ExtrahiereVokale(string text)
        {
            string result = "";
            //Array to track if we#ve already found each vowel
            //We have 10 slots for a,e,i,o,u,A,E,I,O,U
            //But we only use  the first 5 since we convert to lowercase for checking
            bool[] gefundeneVokale = new bool[10]; // Index für a,e,i,o,u,A,E,I,O,U

            //Check each charter in the input text
            foreach (char c in text)
            {
                // Convert to lowercase for comparison, but keep original case when adding to result
                switch (char.ToLower(c))
                {
                    case 'a':
                        if (!gefundeneVokale[0])
                        {
                            result += c;// Add with original case
                            gefundeneVokale[0] = true;// Mark as found
                        }
                        break;
                    case 'e':
                        if (!gefundeneVokale[1])
                        {
                            result += c;
                            gefundeneVokale[1] = true;
                        }
                        break;
                    case 'i':
                        if (!gefundeneVokale[2])
                        {
                            result += c;
                            gefundeneVokale[2] = true;
                        }
                        break;
                    case 'o':
                        if (!gefundeneVokale[3])
                        {
                            result += c;
                            gefundeneVokale[3] = true;
                        }
                        break;
                    case 'u':
                        if (!gefundeneVokale[4])
                        {
                            result += c;
                            gefundeneVokale[4] = true;
                        }
                        break;
                }
            }
            // Return the string of extracted vowels
            return result;
        }
    }
}