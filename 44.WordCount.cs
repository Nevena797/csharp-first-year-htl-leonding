using System;

static int CountWords(string sentence)
{
    if (string.IsNullOrWhiteSpace(sentence))  // Prüft ob der String leer oder nur Leerzeichen enthält
        return 0;

    int wordCount = 0;
    bool inWord = false;

    for (int i = 0; i < sentence.Length; i++)
    {
        if (char.IsWhiteSpace(sentence[i]))
        {
            inWord = false;
        }
        else if (!inWord)
        {
            inWord = true;
            wordCount++;
        }
    }

    return wordCount;
}

Console.WriteLine("Count words in a sentence");
Console.WriteLine("****************************");

while (true)
{
    Console.Write("Sentence: ");
    string input = Console.ReadLine();

    if (input.ToLower() == "end")
        break;

    int words = CountWords(input);
    Console.WriteLine($"The sentence \"{input}\" has {words} word{(words != 1 ? "s" : "")}.");
}