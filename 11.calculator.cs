string calculator = "Calculator - Ihr Zahlenbegleiter";
int breite = 43;
string rand = new string('*', breite);
string ersteEingabe;
string zweiteEingabe;

Console.WriteLine(rand);
Console.WriteLine($"*   {calculator,-38}*");
Console.WriteLine($"*{new string(' ', breite - 2)}*");
Console.WriteLine(rand);

Console.WriteLine("1. Zahl eingeben: ");
ersteEingabe = Console.ReadLine();
double erste = double.Parse(ersteEingabe);

Console.WriteLine("2. Zahl eingeben: ");
zweiteEingabe = Console.ReadLine();
double zweite = double.Parse(zweiteEingabe);

Console.WriteLine("3. Operation eingeben [ + - * / ]: ");
string eingabeOperator = Console.ReadLine();

double ergebnis = 0;
bool gueltigeEingabe = true;

string fehlermeldung = null;


if (eingabeOperator == "+")
{
    ergebnis = erste + zweite;
}
else if (eingabeOperator == "-")
{
    ergebnis = erste - zweite;
}
else if (eingabeOperator == "*")
{
    ergebnis = erste * zweite;
}
else if (eingabeOperator == "/")
{
    if (zweite != 0)
    {
        ergebnis = erste / zweite;
    }
    else
    {
        gueltigeEingabe = false;
        fehlermeldung = "Division durch 0 ist nicht erlaubt!";
    }
}
else
{
    gueltigeEingabe = false;
    fehlermeldung = "Falsche Rechenart. Bitte geben Sie einen der folgenden Operatoren ein: +, -, *, /.";
}


if (gueltigeEingabe)
{
    Console.WriteLine($"Ergebnis von {erste} {eingabeOperator} {zweite} = {ergebnis:f4}");
}
else
{
    Console.WriteLine(fehlermeldung);
}

Console.WriteLine("Drücken Sie eine beliebige Taste...");
Console.ReadKey();