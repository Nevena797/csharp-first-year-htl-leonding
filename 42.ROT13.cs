class Program
{
    static void Main()
    {
        Console.Write("Please enter a text: ");
        string text = Console.ReadLine();

        string encrypted = Rot13(text);

        Console.WriteLine($"Plain: {text}");
        Console.WriteLine($"Encrypted: {encrypted}");
        Console.WriteLine($"Decrypted: {Rot13(encrypted)}");
    }

    static string Rot13(string text)
    {
        char[] result = text.ToCharArray();

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] >= 'a' && result[i] <= 'z')
            {
                int newPos = ((result[i] - 'a' + 13) % 26) + 'a';
                result[i] = (char)newPos;
            }
        }

        return new string(result);
    }
}