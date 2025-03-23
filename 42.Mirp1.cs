int number = 0;
int reversed = reversedNumber(number);

for (int i = 0; i < 1000; i++)
{
    if (isPrim(i) && isPrim(reversedNumber(i)))
    {
        Console.Write(i);
        if (number == 10)
        {
            Console.WriteLine();
            number = 0;
        }
        else
        {
            Console.Write(", ");
            number++ ;
        }
    }

}
int reversedNumber(int inputNumber)
{
    string firstNumber = inputNumber.ToString();
    string outputNumber = "";
    for (int i = firstNumber.Length - 1; i >= 0; i--)
    {
        outputNumber += firstNumber[i];
    }
    return Convert.ToInt32(outputNumber);
}
bool isPrim(int numberTwo)
{
    if (numberTwo == 1 || numberTwo == 2)
    {
        return true;
    }
    for (int i = 3; i < numberTwo; i += 2)
    {
        if (numberTwo % i == 0)
        {
            return false;
        }
    }
    return true;

}
