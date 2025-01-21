using System;

Console.WriteLine("Convert decimal to binary");
Console.WriteLine("==================================================");

while (true)
{
    Console.Write("Please enter decimal value [int]: ");
    string input = Console.ReadLine();


    if (input.ToLower() == "x")
    {
        break;
    }
    if (int.TryParse(input, out int decimalNumber))
    {
        string binary = Convert.ToString(decimalNumber, 2);

        Console.WriteLine($"Decimal number: {decimalNumber} as binary: {binary}");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
}

Console.WriteLine("Program terminated.");


