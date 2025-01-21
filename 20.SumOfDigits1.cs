Console.WriteLine("Sum of digits calculation");
Console.WriteLine("=========================");
string userInput;

do
{
    Console.Write("Please enter a number [1..int.Max]: ");
    string input = Console.ReadLine()?.Trim();

    bool isValidInput = true;
    foreach (char c in input)
    {
        if (!char.IsDigit(c)) 
        {
            isValidInput = false;
            break;
        }
    }

    if (isValidInput && input.Length > 0)
    {
        int number = Convert.ToInt32(input);  
        int originalNumber = number;
        int sum = 0;
        string digitSequence = "";

        while (number > 0)
        {
            int digit = number % 10;   
            sum += digit;
            digitSequence = digit + (digitSequence == "" ? "" : " + ") + digitSequence;
            number /= 10; 
        }

        Console.WriteLine($"{digitSequence} = {sum}");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a positive integer.");
    }

    Console.Write("Continue (yes/no): ");
    userInput = Console.ReadLine()?.Trim().ToLower();

} while (userInput == "yes");

Console.WriteLine("Program terminated.");
