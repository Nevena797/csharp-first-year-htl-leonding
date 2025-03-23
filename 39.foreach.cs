using System;

class Program
{
    static void Main()
    {
        string input = "Hello";

        foreach (char c in input)
        {
            Console.WriteLine(c);
        }
    }
}

//for (int i = 0; i < input.Length; i++)
//Schreibgeschützt: Sie können Elemente nicht direkt in foreach ändern.
//Indizierungsfehler vermeiden. Kein Index!
//Funktioniert mit jeder Sammlung, die IEnumerable unterstützt – Arrays, Listen, Zeichenfolgen.