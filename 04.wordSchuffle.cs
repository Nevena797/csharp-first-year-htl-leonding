using System;

string firstWord;
string secondWord;
string thurdWord;

Console.Write("Please enter a first word: ");
firstWord = Console.ReadLine();
Console.Write("Please enter a second word: ");
secondWord = Console.ReadLine();
Console.Write("Please enter a third word: ");
thurdWord = Console.ReadLine();

Console.WriteLine(firstWord + ' ' + secondWord + ' ' + thurdWord);
Console.WriteLine(firstWord + ' ' + thurdWord + ' ' + secondWord);
Console.WriteLine(secondWord + ' ' + firstWord + ' ' + thurdWord);
Console.WriteLine(secondWord + ' ' + thurdWord + ' ' + firstWord);
Console.WriteLine(thurdWord + ' ' + firstWord + ' ' + secondWord);
Console.WriteLine(thurdWord + ' ' + secondWord + ' ' + firstWord);

Console.ReadLine();
