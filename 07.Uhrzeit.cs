/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3 ACIF
 *--------------------------------------------------------------
 *              Nevena Rogova
 *--------------------------------------------------------------
 * Description:
 * seconds with format d:hh:mm:ss
 *--------------------------------------------------------------
*/

using System;

string input;
int totalSeconds;
int totalMinutes;
int totalHours;

int minutes;
int hours;
int seconds;
int days;

Console.WriteLine("Bitte geben Sie die Sekunden ein: ");
input = Console.ReadLine();
totalSeconds = int.Parse(input);

seconds = totalSeconds % 60;
totalMinutes = totalSeconds / 60;

minutes = totalMinutes % 60;
totalHours = totalMinutes / 60;

hours = totalHours % 24;
days = totalHours / 24;

if (days == 0)
{
    Console.WriteLine($"Umgerechnet in das Format hh:mm:ss {hours:00}:{minutes:00}:{seconds:00}");
}
else if (days == 1)
{
    Console.WriteLine($"Umgerechnet in das Format hh:mm:ss {days} Tag {hours:00}:{minutes:00}:{seconds:00}");
}
else
{
    Console.WriteLine($"Umgerechnet in das Format hh:mm:ss {days} Tage {hours:00}:{minutes:00}:{seconds:00}");
}

Console.ReadLine();

