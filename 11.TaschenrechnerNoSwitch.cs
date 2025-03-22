using System;

double leftOperand;
double rightOperand;
string operatorText;
string userInput;
double result;
string errorText = "";
bool isError = false;


Console.WriteLine("Einfacher Rechner");
Console.WriteLine("=================");
Console.WriteLine();
Console.Write("Linker Operand [double]: ");
userInput = Console.ReadLine();
leftOperand = double.Parse(userInput);
Console.Write("Operation [+ - * /]: ");
operatorText = Console.ReadLine();
Console.Write("Rechter Operand [double]: ");
userInput = Console.ReadLine();
rightOperand = double.Parse(userInput);


if (operatorText == "+")
{
    result = leftOperand + rightOperand;
}
else if (operatorText == "-")
{
    result = leftOperand - rightOperand;
}
else if (operatorText == "*")
{
    result = leftOperand * rightOperand;
}
else if (operatorText == "/")
{
    if (rightOperand == 0)
    {
        isError = true;
        errorText = "Division durch 0 ist nicht erlaubt!";
        result = 0;
    }
    else
    {
        result = leftOperand / rightOperand;
    }
}
else
{
    isError = true;
    errorText = "Falsche Rechenart: " + operatorText;
    result = 0;
}


if (isError)
{
    Console.WriteLine(errorText);
}
else
{
    Console.WriteLine($"Ergebnis von {leftOperand} {operatorText} {rightOperand} = {result:f3}");
}
