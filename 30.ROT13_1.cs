using System.ComponentModel.Design;

namespace _30.ROT13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Einfache Verschlüsselung mit ROT13");
            Console.Write("Zu verschlüsselnden Text eingeben: ");
            string text = Console.ReadLine();
            string encryptedResult = "";

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                char toNewChar = currentChar;

                if (currentChar >= 'a' && currentChar <= 'z')
                {
                    toNewChar =
                        currentChar + 13 > 'z' ? // invalid index
                        (char)(currentChar - 13) // do to valid index
                        : (char)(currentChar + 13);//else entcrupted char
                }
                else if (currentChar >= 'A' && currentChar <= 'Z')
                {
                    toNewChar =
                        currentChar + 13 > 'Z' ?
                        (char)(currentChar - 13)
                        : (char)(currentChar + 13);
                }
                encryptedResult += toNewChar;
            }
            Console.WriteLine("Verschlüsselt:" + encryptedResult);

            string decrypted = "";

            for (int i = 0; i < encryptedResult.Length; i++)
            {
                char currentChar = encryptedResult[i];
                char toNewChar = currentChar;

                if (currentChar >= 'a' && currentChar <= 'z')
                {
                    toNewChar = (char)('a' + ((currentChar + 13 - 'a') % 26));
                }
                else if (currentChar >= 'A' && currentChar <= 'Z')
                {
                    toNewChar = (char)('A' + ((currentChar + 13 - 'A') % 26));
                }
                decrypted += toNewChar;
            }
            Console.WriteLine("Entschlüsselt: " + decrypted);
        }
    }
}