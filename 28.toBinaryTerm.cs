/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3 ACIF
 *--------------------------------------------------------------
 *              Nevena Rogova
 *--------------------------------------------------------------
 * Description:
 * BinSearch
 *--------------------------------------------------------------
*/
using System;

Console.WriteLine("Convert decimal to binary");
Console.WriteLine("======================================");
Console.WriteLine();

bool isOk;
int number;

do
{
    Console.Write("Please enter number [1..]: ");
    isOk = int.TryParse(Console.ReadLine(), out number);
} while (!isOk || number < 1);


int remainingNumber = number;
string termString = "";

for (int bit = 0; remainingNumber > 0; bit++)
{
    int remaining = remainingNumber % 2;
    remainingNumber = remainingNumber / 2;

    if (remaining > 0)
    {
        if (!string.IsNullOrEmpty(termString!))
        {
            termString = " + " + termString;
        }
        termString = $"2^{bit}" + termString;
    }
}

Console.WriteLine();
Console.WriteLine($"The number {number} can be written as: {termString}");