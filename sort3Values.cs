// Werte einlesen
Console.WriteLine("Geben Sie den ersten Wert ein:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Geben Sie den zweiten Wert ein:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Geben Sie den dritten Wert ein:");
int x3 = Convert.ToInt32(Console.ReadLine());

int temp;

// Verzweigung zur Sortierung
if (x1 > x2)
{
    // x1 und x2 vertauschen
   temp = x1;
    x1 = x2;
    x2 = temp;
}

if (x2 > x3)
{
    // x2 und x3 vertauschen
    temp = x2;
    x2 = x3;
    x3 = temp;
}

if (x1 > x2)
{
    // x2 und x3 vertauschen
    temp = x1;
    x1 = x2;
    x2 = temp;
}

// Ausgabe der Werte
Console.WriteLine($"Die sortierten Werte sind: {x1}, {x2}, {x3}");
