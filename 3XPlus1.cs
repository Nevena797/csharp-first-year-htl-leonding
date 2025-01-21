Console.WriteLine("Calculate 3x + 1");
Console.WriteLine("=================");

Console.Write("Please enter start value: ");
if (!int.TryParse(Console.ReadLine(), out int val) || val <= 0)
{
    Console.WriteLine("Invalid input. Please enter a positive integer.");
    return;
}

int count = 0;
int maxValue = val;
int overflow = int.MaxValue;

while (val > 1)
{
    if (val % 2 != 0) // Ungerade Zahl
    {
        if (val > (overflow - 1) / 3) // Überlaufprüfung
        {
            Console.WriteLine("The input value is too large to ensure safe calculations. Please enter a smaller number.");
            return;
        }

        int result = val * 3 + 1;
        Console.WriteLine($"{val} * 3 + 1 = {result}");
        val = result;
    }
    else // Gerade Zahl
    {
        int result = val / 2;
        Console.WriteLine($"{val} / 2 = {result}");
        val = result;
    }

    if (val > maxValue)
    {
        maxValue = val;
    }
    count++;
}

Console.WriteLine($"{count} iterations needed to reach 1.");
Console.WriteLine($"The maximum value reached was {maxValue}.");

