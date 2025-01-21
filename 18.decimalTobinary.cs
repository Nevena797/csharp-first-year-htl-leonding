string output = " ";

Console.Write("Bitte geben Sie einen Wert ein: ");
int val = int.Parse(Console.ReadLine());

while (val > 0)
{
    int digit = val % 2;

    val /= 2;

    output = $"{digit} {output}";


}
Console.WriteLine(output);


