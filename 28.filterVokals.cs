﻿string text;
string result = "";

Console.WriteLine("Vokale aus Text extrahieren");
Console.WriteLine("===========================");
Console.Write("Text: ");

text = Console.ReadLine();
Console.WriteLine();

for (int i = 0; i < text.Length; i++)
{
    char ch = text[i];
    if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' ||
        ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
    {
        var searchIndex = 0;

        while (searchIndex < result.Length && char.ToLower(result[searchIndex]) != char.ToLower(ch))
        {
            searchIndex++;
        }
        if (searchIndex == result.Length)  
        {
            result += ch;
        }
    }
}
Console.WriteLine($"Der Text \"{text}\" enthält {result.Length} Vokale: {result}");
Console.Write("Beenden mit Eingabetaste ...");
Console.ReadLine();
