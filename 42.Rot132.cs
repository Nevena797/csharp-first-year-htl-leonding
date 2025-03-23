using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Einfache Verschlüsselung mit ROT13");
        Console.Write("Zu verschlüsselnden Text eingeben: ");
        string text = Console.ReadLine();

        string encrypted = EncryptROT13(text);
        Console.WriteLine("Verschlüsselt: " + encrypted);

        string decrypted = DecryptROT13(encrypted);
        Console.WriteLine("Entschlüsselt: " + decrypted);
    }

    static string EncryptROT13(string input)
    {
        return TransformROT13(input);
    }

    static string DecryptROT13(string input)
    {
        return TransformROT13(input); // ROT13 ist symmetrisch
    }

    static string TransformROT13(string input)
    {
        string result = "";

        foreach (char ch in input)
        {
            if (ch >= 'a' && ch <= 'z')
            {
                result += (char)('a' + ((ch - 'a' + 13) % 26));
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                result += (char)('A' + ((ch - 'A' + 13) % 26));
            }
            else
            {
                result += ch; // Nicht-alphabetische Zeichen bleiben unverändert
            }
        }

        return result;
    }
}