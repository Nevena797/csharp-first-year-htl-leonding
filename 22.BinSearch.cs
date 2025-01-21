Console.WriteLine("Think of a number between 1 and 1000. I will try to guess it!");
Console.WriteLine("Respond with:");
Console.WriteLine("[g] if my guess is too low (your number is greater),");
Console.WriteLine("[l] if my guess is too high (your number is less),");
Console.WriteLine("[e] if I guessed correctly.");

int min = 1;
int max = 1000;
int tries = 0;
bool cheatingDetected = false;

while (min <= max)
{
    int guess = (min + max) / 2;
    Console.WriteLine($"My guess is: {guess}");
    Console.Write("Is your number [g]reater, [l]ess or [e]qual: ");
    char response = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (response == 'e')
    {
        tries++;
        Console.WriteLine($"I have found the number within {tries} tries.");
        return;
    }
    else if (response == 'g')
    {
        if (guess == max)
        {
            cheatingDetected = true;
            break;
        }
        min = guess + 1;
    }
    else if (response == 'l')
    {
        if (guess == min)
        {
            cheatingDetected = true;
            break;
        }
        max = guess - 1;
    }
    else
    {
        Console.WriteLine("Invalid input. Please respond with [g], [l], or [e].");
        continue;
    }

    tries++;
}

if (cheatingDetected)
{
    Console.WriteLine("You are cheating!");
}
