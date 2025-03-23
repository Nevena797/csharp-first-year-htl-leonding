//Methoden ohne Parameter
using System.Reflection.Metadata;

static void PrintHeader()
{
    Console.WriteLine("Artikelliste");
    Console.WriteLine("------------");
}

//Parameter in Methoden
static void PrintMax(int x, int y)
{
    if (x > y) Console.Write(x);
    else Console.Write(y);
}

//Methoden mit Rückgabewert (Funktionen)
static int Max(int x, int y)
{
    return x > y ? x : y;
}

//Lokale und statische Variablen
//Lokale Variablen:
static void P()
{
    int x = 0; // lokal
}

// Statische Variablen:
static int sum = 0;

using System; // Namespace für Console-Funktionen

class Sample
{
    // Definition der Methode "PrintHeader"
    static void PrintHeader() // Methodenkopf
    {
        Console.WriteLine("Artikelliste"); // Methodenrumpf
        Console.WriteLine("------------");
    }

    // Hauptmethode
    static void Main(string[] args)
    {
        PrintHeader(); // Aufruf der Methode
        // Hier könnte weiterer Code stehen
        PrintHeader(); // Wiederholter Aufruf der Methode
    }
}

using System; // Für Console.Write

class Sample
{
    // Methode zur Ausgabe des größeren Werts
    static void PrintMax(int x, int y)
    {
        if (x > y)
        {
            Console.Write(x);
        }
        else
        {
            Console.Write(y);
        }
    }

    // Hauptmethode
    static void Main()
    {
        int i = 10; // Beispielwert für i
        PrintMax(100, 2 * i); // Aufruf der Methode
    }
}

//Methoden mit Rückgabewert (Funktionen)
class Sample
{
    static int Max(int x, int y)
    {
        if (x > y)
            return x;
        else
            return y;
    }
}
//Aufruf der Methode in Main
//static void Main(string[] arg)
//{
//    int i = 10;
//    int j = 20;
//    Console.WriteLine(Max(100, i + j) + 1);
//}


//Methoden ohne Rückgabewert (Prozeduren)
class Sample
{
    static void PrintMessage()
    {
        Console.WriteLine("Hallo, Welt!");
    }
}
// Ganzzahliger Zweierlogarithmus
//Die Log2 Methode
class Sample
{
    static int Log2(int x)
    {
        // assert: x >= 0
        int expo = 0;
        while (x > 1)
        {
            x = x / 2;
            expo++;
        }
        return expo;
    }
}
//static void Main()
//{
//    int x = Log2(17);  // x == 4
//    ...
//}

//Statische Variablen
class C
{
    static int a, b;

    static void P()
    {
        int x, y;
        // ...
    }
}
//Lokale Variablen
//static void P()
//{
//    int x, y;
//    // ...
//}

// Falsch
class Wrong
{
    static void Add(int x)
    {
        int sum = 0;
        sum = sum + x;
    }

    static void Main()
    {
        Add(1);
        Add(2);
        Add(3);
        Console.WriteLine("sum = " + sum);
    }
}

//Richtig 
class Correct
{
    static int sum = 0;  // Statische Variable, die den Gesamtwert behält

    static void Add(int x)
    {
        sum = sum + x;  // Summe wird bei jedem Aufruf erhöht
    }

    static void Main()
    {
        Add(1);
        Add(2);
        Add(3);
        Console.WriteLine("sum = " + sum);  // Gibt die korrekte Summe aus
    }
}
//Richtig 2 -ref
class Correct
{
    static void Add(ref int sum, int x)
    {
        sum = sum + x;  // Summe wird bei jedem Aufruf erhöht
    }

    static void Main()
    {
        int sum = 0;  // Lokale Variable sum in Main
        Add(ref sum, 1);
        Add(ref sum, 2);
        Add(ref sum, 3);
        Console.WriteLine("sum = " + sum);  // Gibt die korrekte Summe aus
    }
}

//Sichtbarkeitsbereich (auch Gültigkeitsbereich oder Scope)
class Sample
{
    static void P()
    {
        ...
    }

    static int x;  // Klassenweite Variable x
    static int y;  // Klassenweite Variable y

    static void Q(int z)
    {
        int x;  // Lokale Variable x, die die Klassenweite x verdeckt
        ...
    }
}
//---Du kannst jedoch nicht zwei lokale Variablen mit dem gleichen Namen im gleichen Block deklarieren.

//static void Q(int z)
//{
//    int x;  // Erlaubt
//    int x;  // Fehler! x wurde schon einmal deklariert
//}

//
//static int x = 5;  // Klassenweite Variable x

//static void Q(int z)
//{
//    int x = 10;  // Lokale Variable x, die die Klassenweite x verdeckt
//    Console.WriteLine(x);  // Gibt 10 aus, weil die lokale Variable x die Klassenweite verdeckt

class Sample
{
    static int x = 5;  // Klassenweite Variable

    static void P()
    {
        Console.WriteLine(x);  // x ist hier sichtbar und gibt 5 aus
    }

    static void Q(int z)
    {
        Console.WriteLine(x);  // x ist hier ebenfalls sichtbar und gibt 5 aus
    }
}

class Sample
{
    static void P()
    {
        Console.WriteLine(x);  // Zugriff auf das statische x
        x = 2;  // Veränderung von x
    }

    static int x = 0;  // Statische Variable x

    static void Main()
    {
        Console.WriteLine(x);  // Gibt 0 aus, da x hier noch nicht überschattet wurde
        int x = 1;  // Lokale Variable x in Main, die das statische x verdeckt
        Console.WriteLine(x);  // Gibt 1 aus, da die lokale Variable x hier verwendet wird
        P();  // Ruft die Methode P auf
        if (x > 0)
        {
            int x;  // Neue lokale Variable x im "then"-Zweig
            int y;  // Neue lokale Variable y im "then"-Zweig
            ...
        }
        else
        {
            int y;  // Neue lokale Variable y im "else"-Zweig
            ...
        }
    }
}


