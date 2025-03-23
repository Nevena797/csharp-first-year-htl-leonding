using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<char> userDigits = new();

        userDigits.Add('1');
        userDigits.Add('2');
        userDigits.Add('2'); // Wird ignoriert, da „2“ bereits vorhanden ist

        foreach (char c in userDigits)
        {
            Console.WriteLine(c);
        }
    }
}
