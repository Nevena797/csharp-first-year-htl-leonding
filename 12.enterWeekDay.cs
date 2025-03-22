Console.WriteLine("Wochentagseingabe");
Console.WriteLine("-----------------------");

Console.WriteLine("Bitte geben sie den ersten Buchstaben des Wochentags ein[MDMDFSS]");
string dayAbbreviation = Console.ReadLine();

switch (dayAbbreviation)
{
    case "M":
        Console.WriteLine("Bitte geben sie den zweiten Buchstaben des Wochentags ein [OI]: ");
        dayAbbreviation = Console.ReadLine();
        switch (dayAbbreviation)
        {
            case "O":
                Console.WriteLine("Sie haben Montag ausgewählt");
                break;
            case "I":
                Console.WriteLine("Sie haben Mittwoch ausgewählt");
                break;
            default:
                Console.WriteLine("Ungültige Eingabe \"{dayAbbreviation}\", O bzw. I erwartet.");
                break;
        }
        break;
    case "D":
        Console.WriteLine("Bitte geben sie den zweiten Buchstaben des Wochentags ein [IO]: ");
        dayAbbreviation = Console.ReadLine();
        switch (dayAbbreviation)
        {
            case "I":
                Console.WriteLine("Sie haben Dienstag ausgewählt");
                break;
            case "O":
                Console.WriteLine("Sie haben Donnerstag ausgewählt");
                break;
            default:
                Console.WriteLine("Ungültige Eingabe \"{dayAbbreviation}\", I bzw. O erwartet.");
                break;
        }
        break;
    case "F":
        Console.WriteLine("Sie haben Freitag ausgewählt\");
            break;
    case "S":
        Console.WriteLine("Bitte geben sie den zweiten Buchstaben des Wochentags ein [AO]: ");
        switch (dayAbbreviation)
        {
            case "A":
                Console.WriteLine("Sie haben Samstag ausgewählt");
                break;
            case "O":
                Console.WriteLine("Sie haben Sonntag ausgewählt");
                break;
            default:
                Console.WriteLine("Ungültige Eingabe \"{dayAbbreviation}\", A bzw. O erwartet.");
                break;
        }
        break ;
    default:
        Console.WriteLine("Ungültige Eingabe \"{dayAbbreviation}\", M, D, F oder S erwartet.");
        break ;
}
