Console.Write("Please enter a positive integer (> 1): ");
int number = int.Parse(Console.ReadLine());
int originalNumber = number; 

Console.Write($"{originalNumber} = 1");

int divisor = 2; 
while (number > 1)
{
    while (number % divisor == 0) 
    {
        Console.Write($" * {divisor}");
        number /= divisor; 
    }
    divisor++; 
}

Console.WriteLine();

