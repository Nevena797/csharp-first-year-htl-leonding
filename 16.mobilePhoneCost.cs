// Eingabe der monatlichen Kosten
Console.Write("Bitte geben Sie die monatlichen Kosten (0 < wert < 1000) ein: ");
double monatlicheKosten = Convert.ToDouble(Console.ReadLine());

// Überprüfung der monatlichen Kosten
if (monatlicheKosten <= 0 || monatlicheKosten >= 1000)
{
    Console.WriteLine("Fehler: Die monatlichen Kosten müssen im Bereich 0 < wert < 1000 liegen.");
    return;
}

// Eingabe der jährlichen Servicepauschale
Console.Write("Bitte geben Sie die jährliche Servicepauschale (0 <= wert < 1000) ein: ");
double servicepauschale = Convert.ToDouble(Console.ReadLine());

// Überprüfung der jährlichen Servicepauschale
if (servicepauschale < 0 || servicepauschale >= 1000)
{
    Console.WriteLine("Fehler: Die jährliche Servicepauschale muss im Bereich 0 <= wert < 1000 liegen.");
    return;
}

// Eingabe des einmaligen Aktivierungsentgelts
Console.Write("Bitte geben Sie das einmalige Aktivierungsentgelt (0 <= wert < 1000) ein: ");
double aktivierungsentgelt = Convert.ToDouble(Console.ReadLine());

// Überprüfung des einmaligen Aktivierungsentgelts
if (aktivierungsentgelt < 0 || aktivierungsentgelt >= 1000)
{
    Console.WriteLine("Fehler: Das einmalige Aktivierungsentgelt muss im Bereich 0 <= wert < 1000 liegen.");
    return;
}

// Berechnung der Kosten
double ersteJahrKosten = aktivierungsentgelt + (monatlicheKosten * 12) + servicepauschale;
double folgendeJahrKosten = (monatlicheKosten * 12) + servicepauschale;

// Ausgabe der Ergebnisse
if (aktivierungsentgelt > 0)
{
    Console.WriteLine($"Die Kosten für das erste Jahr betragen: {ersteJahrKosten:F2} Euro.");
}
Console.WriteLine($"Die monatlichen Kosten betragen: {monatlicheKosten:F2} Euro.");
Console.WriteLine($"Die Kosten für die folgenden Jahre betragen: {folgendeJahrKosten:F2} Euro.");

