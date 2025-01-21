using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


Console.Write("Bitte geben Sie einen Wert ein: ");
int val = int.Parse(Console.ReadLine());
int sumOfDigits = 0;

while (val > 0)
{
    int digit = val % 10;

    val /= 10;      //val = val /10;

    sumOfDigits += digit;

}
Console.WriteLine($"Digit = {sumOfDigits}");

