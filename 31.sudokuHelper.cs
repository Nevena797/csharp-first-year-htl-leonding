const string validDigits = "123456789";
Console.WriteLine("Sudoku Helper - Find possible numbers");
Console.WriteLine("======================================");

bool exit = false;

while (!exit)
{
    Console.Write("Enter digits (empty to exit): ");
    string input = Console.ReadLine();
    exit = string.IsNullOrWhiteSpace(input);

    if (!exit && IsValidInput(input))
    {
        string missingDigits = "";
        foreach (char c in validDigits)
            if (!input.Contains(c)) missingDigits += c;

        Console.WriteLine(string.IsNullOrEmpty(missingDigits) ? "nothing is possible" : $"{missingDigits} is possible");
    }
    else if (!exit)
    {
        Console.WriteLine("Invalid input! Use unique digits 1-9.");
    }
}

Console.WriteLine("Exiting. Goodbye!");


static bool IsValidInput(string input)
{
    foreach (char c in input)
    {
        if (c == ' ') continue;

        if (c < '1' || c > '9' || input.Count(x => x == c) > 1)
            return false;
    }
    return true;
}
