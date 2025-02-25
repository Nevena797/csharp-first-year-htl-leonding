using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a sentence: ");
        string input = Console.ReadLine();


        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Compressed sentence: \"\"");
            return;
        }

        StringBuilder output = new StringBuilder();
        bool insideWord = false;

        foreach (char c in input)
        {
            if (!char.IsWhiteSpace(c))
            {
                output.Append(c);
                insideWord = true;
            }
            else if (insideWord)
            {
                output.Append(' ');
                insideWord = false;
            }
        }
        string result = output.ToString().TrimEnd();
        Console.WriteLine($"Compressed sentence: \"{result}\"");
    }
}
