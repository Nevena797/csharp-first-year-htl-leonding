﻿using System.ComponentModel.Design;

string input;
int year;

Console.Write("Bitte geben sie eine Jahreszahl ein: ");
input = Console.ReadLine();
year = int.Parse(input);

if (year % 4 == 0)
{
    if (year % 100 == 0)
    {
        if (year % 400 == 0)
        {
            Console.WriteLine("Schaltjahr");
        }
        else
        {
            Console.WriteLine("Kein Schaltjahr");
        }
    }
    else
    {
        Console.WriteLine("Schaltjahr");
    }
}
else
{
    Console.WriteLine("Kein Schaltjahr");
}   