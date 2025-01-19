Console.WriteLine("Bitte geben Sie den ersten Buchstaben des Wochentags ein (nur Großbuchstaben):");
char ersterBuchstabe = Console.ReadKey().KeyChar;
Console.WriteLine();

switch (ersterBuchstabe)
{
    case 'M':
        // Montag oder Mittwoch
        Console.WriteLine("Bitte geben Sie den zweiten Buchstaben ein:");
        char zweiterBuchstabeM = Console.ReadKey().KeyChar;
        Console.WriteLine();
        switch (zweiterBuchstabeM)
        {
            case 'O':
                Console.WriteLine("Sie haben Montag ausgewählt.");
                break;
            case 'I':
                Console.WriteLine("Sie haben Mittwoch ausgewählt.");
                break;
            default:
                Console.WriteLine("Ungültige Eingabe für den zweiten Buchstaben.");
                break;
        }
        break;

    case 'D':
        // Dienstag oder Donnerstag
        Console.WriteLine("Bitte geben Sie den zweiten Buchstaben ein:");
        char zweiterBuchstabeD = Console.ReadKey().KeyChar;
        Console.WriteLine();
        switch (zweiterBuchstabeD)
        {
            case 'I':
                Console.WriteLine("Sie haben Dienstag ausgewählt.");
                break;
            case 'O':
                Console.WriteLine("Sie haben Donnerstag ausgewählt.");
                break;
            default:
                Console.WriteLine("Ungültige Eingabe für den zweiten Buchstaben.");
                break;
        }
        break;

    case 'F':
        // Freitag
        Console.WriteLine("Sie haben Freitag ausgewählt.");
        break;

    case 'S':
        // Samstag oder Sonntag
        Console.WriteLine("Bitte geben Sie den zweiten Buchstaben ein:");
        char zweiterBuchstabeS = Console.ReadKey().KeyChar;
        Console.WriteLine();
        switch (zweiterBuchstabeS)
        {
            case 'A':
                Console.WriteLine("Sie haben Samstag ausgewählt.");
                break;
            case 'O':
                Console.WriteLine("Sie haben Sonntag ausgewählt.");
                break;
            default:
                Console.WriteLine("Ungültige Eingabe für den zweiten Buchstaben.");
                break;
        }
        break;

    default:
        // Ungültige Eingabe
        Console.WriteLine("Ungültige Eingabe. Kein Wochentag beginnt mit diesem Buchstaben.");
        break;
}

Console.WriteLine("Please enter the first letter of the month (uppercase only):");
char firstLetter = Console.ReadKey().KeyChar;
Console.WriteLine();


switch (firstLetter)
{
    case 'J':
        Console.WriteLine("Please enter the second letter (A for January, U for June or July):");
        char secondLetterJ = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (secondLetterJ == 'A')
        {
            Console.WriteLine("You selected January.");
        }
        else if (secondLetterJ == 'U')
        {

            Console.WriteLine("Please enter the third letter (N for June, L for July):");
            char thirdLetter = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (thirdLetter == 'N')
            {
                Console.WriteLine("You selected June.");
            }
            else if (thirdLetter == 'L')
            {
                Console.WriteLine("You selected July.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
        break;

    case 'F':
        Console.WriteLine("You selected February.");
        break;

    case 'M':

        Console.WriteLine("Please enter the second letter (A for March, Y for May):");
        char secondLetterM = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (secondLetterM == 'A')
        {
            Console.WriteLine("You selected March.");
        }
        else if (secondLetterM == 'Y')
        {
            Console.WriteLine("You selected May.");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
        break;

    case 'A':
        Console.WriteLine("You selected April.");
        break;

    case 'S':
        Console.WriteLine("You selected September.");
        break;

    case 'O':
        Console.WriteLine("You selected October.");
        break;

    case 'N':
        Console.WriteLine("You selected November.");
        break;

    case 'D':
        Console.WriteLine("You selected December.");
        break;

    default:
        Console.WriteLine("Invalid first letter.");
        break;
}
