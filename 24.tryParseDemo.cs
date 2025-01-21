bool isOK;
int myValue;

do
{
    Console.Write("Please enter value [0..100]: ");
    isOK =
        int.TryParse(Console.ReadLine(), out myValue) &&
        myValue >= 0 &&
        myValue <= 100;

    if (!isOK)
    {
        Console.WriteLine("ungültiger Wert!");
    }

} while (!isOK);

Console.WriteLine($"Value={myValue}");