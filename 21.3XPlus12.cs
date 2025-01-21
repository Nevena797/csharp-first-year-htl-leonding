﻿using System;

Console.WriteLine("Calculated 3x + 1");
Console.WriteLine("=================");
Console.WriteLine();

Console.Write("Please enter start value: ");
int val = Convert.ToInt32(Console.ReadLine());
int count = 0;
int maxValue = 0;

while (val > 1)
{
    if (val % 2 != 0)
    {
        Console.Write($"{val} * 3 + 1 =");
        val = 3 * val + 1;
    }
    else
    {
        Console.Write($"{val} / 2 =");
        val /= 2;
    }

    if (maxValue < val)
    {
        maxValue = val;
    }

    count++;
    Console.WriteLine($" {val}");
}

Console.WriteLine($"{count} iterations needed to reach 1.");
Console.WriteLine($"{maxValue} is the highest value.");
