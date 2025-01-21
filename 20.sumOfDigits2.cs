
Console.WriteLine("Sum of digits calculation");
Console.WriteLine("=========================");

string userInput = "";
do
{

    Console.Write("Please enter a number [1..int.Max]: ");

    if (!int.TryParse(Console.ReadLine(), out int number) || number < 1)
    {
        Console.WriteLine("Invalid input. Please enter a positive integer.");
        continue; 
    }

    int sumOfDigits = 0;
    string digitBreakdown = "";


    while (number != 0)
    {
        int digit = number % 10;
        sumOfDigits += digit;
        digitBreakdown = digit + (digitBreakdown == "" ? "" : "+") + digitBreakdown;
        number /= 10;
    }


    Console.WriteLine($"{digitBreakdown} = {sumOfDigits}");


    Console.Write("Continue (yes/no): ");
    userInput = Console.ReadLine()?.Trim().ToLower();

} while (userInput == "yes"); 

Console.WriteLine("Program terminated.");
