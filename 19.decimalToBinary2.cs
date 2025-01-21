using System;

Console.WriteLine("Convert decimal to binary");
Console.WriteLine("======================================");
Console.WriteLine();
Console.WriteLine("Please enter decimal value [int,>=0]: ");
int decimalNumber = int.Parse(Console.ReadLine());

var remainingNumber = decimalNumber;
string binaryString = "";
while (remainingNumber > 0)
{
    var remaining = remainingNumber % 2;
    remainingNumber = remaining / 2;

    binaryString = remaining + binaryString;
}

Console.WriteLine();
Console.WriteLine($"Decimal number: {decimalNumber} as binary: {binaryString}");