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

time = distance / speed; //(double)time = 50.00 / 20.00 = 2.5
hour = (int)time;       // hour = (int)2.5 = 2
min = time - hour;     //(double) min = (2.5 - 2.0) = 0.5
min = min * 60;       //(double)min = 0.5 * 60 = 30
intmin = (int)min;   //intmin = (int) 30;
sec = min - intmin; //sec = (30 - 30) = 0;
sec = sec * 60;    // sec = 0 * 60;


hour = hour + 10; // 2 = 2 + 10; 


Console.WriteLine($"Fuer die Strecke von {distance:f} km benoetigen Sie {time:f4} Stunden. Sie kommen um {hour:00}:{intmin:00}:{sec:00} an.");


Console.ReadLine();

