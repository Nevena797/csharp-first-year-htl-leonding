using System;

class Program
{
    static int SkipLeadingSpaces(string str, int startIdx)
    {
        for (int i = startIdx; i < str.Length; i++)
        {
            if (!char.IsWhiteSpace(str[i]))
            {
                return i;
            }
        }
        return str.Length;
    }

    static void Main()
    {
        string text1 = "   Hallo Welt!";
        int index1 = SkipLeadingSpaces(text1, 0);
        Console.WriteLine(index1);
        // Gibt 3 zurück, weil das erste nicht-leere Zeichen 'H' ist.

        string text2 = "      ";
        int index2 = SkipLeadingSpaces(text2, 0);
        Console.WriteLine(index2);
        // Gibt 6 zurück (die Länge der Zeichenkette), da nur Leerzeichen vorhanden sind.
    }
}
