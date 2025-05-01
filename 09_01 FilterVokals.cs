namespace _09_01_FilterVokals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vokale aus Text extrahieren");
            Console.WriteLine("===========================");
            Console.WriteLine("Bitte geben Sie Text ein (oder 'exit' zum Beenden):");
            string text = Console.ReadLine();

            while (text != "exit")
            {
                string vokale = "";
                string bereitsGefunden = ""; 

                for (int i = 0; i < text.Length; i++)
                {
                    char currentchar = text[i];

                    if ("aeiouAEIOU".Contains(currentchar))
                    {
                        char klein = char.ToLower(currentchar);

                        if (!bereitsGefunden.Contains(klein))
                        {
                            vokale += currentchar;        
                            bereitsGefunden += klein;     
                        }
                    }
                }

                if (vokale.Length > 0)
                {
                    Console.WriteLine($"{vokale[0]}"); 
                }

                Console.WriteLine($"Der Text \"{text}\" enthält {vokale.Length} Vokale: \"{vokale}\"");
                Console.WriteLine("Beenden mit Eingabetaste...");
                text = Console.ReadLine();
            }
        }
    }
}

