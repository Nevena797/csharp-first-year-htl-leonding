Console.Write("Please enter month [1..12]: ");
int month = int.Parse(Console.ReadLine());

Console.Write("Please enter day [1..31]: ");
int day = int.Parse(Console.ReadLine());

Console.Write("Berechnung für Schaltjahr [j/n]: ");
char leapYearInput = char.ToLower(Console.ReadKey().KeyChar);
bool isLeapYear = leapYearInput == 'j';


int maxDay = 0;

if (month == 2)
{
    maxDay = isLeapYear ? 29 : 28;
}
else if (month == 4 || month == 6 || month == 9 || month == 11)
{
    maxDay = 30;
}
else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
{
    maxDay = 31;
}
else
{
    Console.WriteLine("\nInvalid month.");
    return;
}

if (day < 1 || day > maxDay)
{
    Console.WriteLine($"\nInvalid day: In month {month}, the valid range is: 1 <= {day} <= {maxDay}");
}
else
{
    int dayOfYear = CalculateDayOfYear(month, day, isLeapYear);
    Console.WriteLine($"\nDay of the year {month}:{day} = {dayOfYear}");
}
    }
    static int CalculateDayOfYear(int month, int day, bool isLeapYear)
{
    int[] daysInMonths = { 31, isLeapYear ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    int dayOfYear = 0;

    for (int i = 0; i < month - 1; i++)
    {
        dayOfYear += daysInMonths[i];
    }

    dayOfYear += day;
    return dayOfYear;
}
