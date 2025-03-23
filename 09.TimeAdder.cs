using System;

string input1;
string input2;
string input3;
string input4;
int hours1;
int minutes1;
int hours2;
int minutes2;
int totalMin;
int extraHours;
int totalHours;
int minutes;

Console.WriteLine("Einfacher Addierer fuer zwei Uhrzeiten ");
Console.WriteLine("====================================");
Console.Write("Stunden 1 [int]: ");
input1 = Console.ReadLine();
hours1 = int.Parse(input1);
Console.Write("Minuten 1 [int]: ");
input2 = Console.ReadLine();
minutes1 = int.Parse(input2);
Console.Write("Stunden 2 [int]: ");
input3 = Console.ReadLine();
hours2 = int.Parse(input3);
Console.Write("Minuten 2 [int]: ");
input4 = Console.ReadLine();
minutes2 = int.Parse(input4);
Console.WriteLine();


totalMin = minutes1 + minutes2;
extraHours = totalMin / 60;
totalHours = hours1 + hours2 + extraHours;
minutes = totalMin % 60;

Console.WriteLine($"{hours1,8}:{minutes1:00}");
Console.WriteLine($"+{hours2,7}:{minutes2:00}");
Console.WriteLine($"={totalHours,7}:{minutes:00}");

Console.ReadLine();

