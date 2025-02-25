using System;

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

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string output = string.Join(' ', words);

        Console.WriteLine($"Compressed sentence: \"{output}\"");
    }
}
