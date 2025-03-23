using System;

Console.WriteLine("Count words in a sentence");
Console.WriteLine("****************************");

while (true)
{
    Console.Write("Sentence: ");
    string input = Console.ReadLine();


    if (IsEnd(input))
    {
        Console.WriteLine("Program terminated.");
        break;
    }


    int wordCount = CountWords(input);


    Console.WriteLine($"The sentence \"{input}\" has {wordCount} words.");
}



static bool IsEnd(string input)
{
    return input.Trim().ToLower() == "end";
}


static int CountWords(string sentence)
{
    if (string.IsNullOrWhiteSpace(sentence))
    {
        return 0;
    }

    string[] words = sentence.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    return words.Length; 
}

