/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: <CLASSNAME>
 *--------------------------------------------------------------
 *              <NAME> 
 *--------------------------------------------------------------
 * Description:
 * ...
 *--------------------------------------------------------------
*/

using System;

string input1;
string input2;
double distance;
double speed;
double time;
double min;
double sec;
int hour;
int intmin;

Console.Write("Entfernung in km: ");
input1 = Console.ReadLine();
distance = double.Parse(input1);
Console.Write("Geschwindigkeit in km/h: ");
input2 = Console.ReadLine();
speed = double.Parse(input2);

time = distance / speed;
hour = (int)time;
min = time - hour;
min = min * 60;
intmin = (int)min;
sec = min - intmin;
sec = sec * 60;


hour = hour + 10;


Console.WriteLine($"Fuer die Strecke von {distance:f} km benoetigen Sie {time:f4} Stunden. Sie kommen um {hour:00}:{intmin:00}:{sec:00} an.");


Console.ReadLine();


/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: xAHIF
 *--------------------------------------------------------------
 *                 / _)     (  _ / _-- _/_ _ 
 *                /(_) .   __)( /)/ ()(/(-/  
 *--------------------------------------------------------------
 * Description: Besuch der Tante.  
 *--------------------------------------------------------------
*/

using System;

Console.WriteLine("Berechnung der Ankunftszeit bei der Tante");
Console.WriteLine("=========================================");
Console.WriteLine();

/**
 * Eingabe
 **/
Console.Write("Entfernung in km: ");
string distanceInput = Console.ReadLine();
double distance = Convert.ToDouble(distanceInput);
Console.Write("Geschwindigkeit in km/h: ");
string velocityInput = Console.ReadLine();
double velocity = Convert.ToDouble(velocityInput);

/**
 * Verarbeitung
 **/
double time = distance / velocity;
int fullHours = (int)time;
double remainingMinutes = (time - fullHours) * 60;
int fullMinutes = (int)(remainingMinutes);
double remainingSeconds = (remainingMinutes - fullMinutes) * 60;
// Damit die restlichen Sekunden richtig gerundet werden, muss
// dann später der double-Wert inkl. Rest ausgegeben werden!
// Bei den Sekunden muss also der Rest erhalten bleiben!
fullHours += 10; // Abfahrt ist um 10:00

/**
 * Ausgabe
 **/
Console.WriteLine("Für die Strecke von {0:f} km benötigen Sie {1:f5} Stunden.", distance, time);
Console.WriteLine("Sie kommen um {0}:{1:00}:{2:00} an.", fullHours, fullMinutes, remainingSeconds);