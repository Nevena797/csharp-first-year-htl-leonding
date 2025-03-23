using System;
using System.Collections.Generic;
using System.Linq; // Notwendig für die Verwendung von `Where`

class Program
{
    static void Main()
    {
        // Definiere eine Zeichenkette mit allen Ziffern von 1 bis 9
        string allDigits = "123456789";

        // Erstelle ein HashSet mit einigen bereits vorhandenen Ziffern
        HashSet<char> userDigits = new() { '1', '3', '5' };

        // Verwende LINQ, um die fehlenden Ziffern zu finden
        var missingDigits = allDigits.Where(d => !userDigits.Contains(d));

        // Gib die fehlenden Ziffern aus
        Console.WriteLine("Folgende Ziffern fehlen:");
        foreach (var digit in missingDigits)
        {
            Console.Write(digit + " ");
        }
    }
}

