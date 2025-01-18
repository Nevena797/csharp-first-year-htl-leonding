using System;


Console.WriteLine("Visitenkarte");
Console.WriteLine("=====================================");
Console.WriteLine();

Console.Write("Bitte geben sie ihren Vornamen ein: ");
var vorname = Console.ReadLine();

Console.Write("Bitte geben sie ihren Nachnamen ein: ");
var nachname = Console.ReadLine();


Console.WriteLine("*******************");
Console.WriteLine($"* {vorname,-15} ");
Console.WriteLine("*******************");
Console.WriteLine($"* {nachname,-15} ");
Console.WriteLine("*******************");

Console.WriteLine();

Console.WriteLine("*******************");
Console.WriteLine($"* {vorname,-15} *");
Console.WriteLine("*******************");
Console.WriteLine($"* {nachname,-15} *");
Console.WriteLine("*******************");
