int hoehe = 0;

// Wiederhole die Eingabe, bis eine gültige Zahl eingegeben wurde
do
{
    Console.Write("Please enter the height: ");
    string eingabe = Console.ReadLine();

    if (int.TryParse(eingabe, out hoehe) && hoehe > 0)
        break;

    Console.WriteLine("Invalid input. Please enter a positive number.");
} while (true);

int kugelCounter = 0;

// Baum zeichnen
for (int zeile = 1; zeile <= hoehe - 1; zeile++)
{
    // Leerzeichen vor den Sternen für Zentrierung
    for (int leer = 0; leer < hoehe - zeile; leer++)
    {
        Console.Write(" ");
    }

    // Sterne und Kugeln zeichnen
    for (int stern = 0; stern < 2 * zeile - 1; stern++)
    {
        kugelCounter++;
        if (kugelCounter % 7 == 0)
        {
            Console.Write("Q"); // Christbaumkugel
        }
        else
        {
            Console.Write("x"); // Normaler Stern
        }
    }
    Console.WriteLine();
}

// Stamm zeichnen (1 Zeile, in der Mitte zentriert)
for (int leer = 0; leer < hoehe - 1; leer++)
{
    Console.Write(" ");
}
Console.WriteLine("x");

