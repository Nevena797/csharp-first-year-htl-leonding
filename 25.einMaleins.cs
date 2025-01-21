int size;
bool isOK;
do
{
    Console.WriteLine("Please enter column/row count [0..31]: ");
    isOK = int.TryParse(Console.ReadLine(), out size) &&
           size >= 0 &&
           size <= 31;

    if (!isOK)
    {
        Console.WriteLine("Ungültiger Wert!");
    }
} while (!isOK); 


if (size == 0)
{
    Console.WriteLine("+");
}
else
{

    for (int row = 1; row <= size; row++) 
    {
        Console.Write("+");
        for (int col = 1; col <= size; col++) 
        {
            Console.Write("---+");
        }
        Console.WriteLine();

        for (int col = 1; col <= size; col++) 
        {
            Console.Write($"|{row * col,3}"); 
        }
        Console.WriteLine("|");
    }


    Console.Write("+");
    for (int col = 1; col <= size; col++)
    {
        Console.Write("---+");
    }
    Console.WriteLine();
}