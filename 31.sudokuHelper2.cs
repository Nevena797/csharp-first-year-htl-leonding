using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Please enter all digits in a row/col/3x3; ");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine(("No input provided.");
            return;
        }

        string allDigits = "123456789";
        HashSet<char> userDigits = new();
        bool isValid = true;

        foreach (char c in input)
        {
            if (char.IsDigit(c) && c != '0')
            {
                if (!userDigits.Add(c))
                {
                    isValid = false;
                    break;
                }
            }
            else if (c != ' ')
            {
                isValid=false;
                break;
            }
        }
        if (!isValid)
        {
            string notFoundDigits = new string(allDigits.Where(d => !userDigits.Contains(d)).ToArray());
            Console.WriteLine($"{(notFoundDigits.Length > 0 ? notFoundDigits : "nothing")} is possible");
        }
        else 
        {
            Console.WriteLine("invalid input");
        }
    }
}
