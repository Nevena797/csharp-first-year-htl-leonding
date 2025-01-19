Console.WriteLine("Day of year calculation with leap year support");
Console.WriteLine("----------------------------------------------");


Console.Write("Please enter month [1..12]: ");
int month = int.Parse(Console.ReadLine());


Console.Write("Please enter day [1..31]: ");
int day = int.Parse(Console.ReadLine());


int year = DateTime.Now.Year;
bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);


int daysInMonth;
if (month == 2)
{
    daysInMonth = isLeapYear ? 29 : 28;
}
else if (month == 4 || month == 6 || month == 9 || month == 11)
{
    daysInMonth = 30;
}
else
{
    daysInMonth = 31;
}


int dayOfYear = day;
for (int m = 1; m < month; m++)
{
    if (m == 2)
    {
        dayOfYear += isLeapYear ? 29 : 28;
    }
    else if (m == 4 || m == 6 || m == 9 || m == 11)
    {
        dayOfYear += 30;
    }
    else
    {
        dayOfYear += 31;
    }
}

Console.WriteLine($"Day of the year for {day}/{month}/{year} = {dayOfYear}");
