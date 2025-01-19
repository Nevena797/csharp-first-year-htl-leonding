Console.WriteLine("Berechnung der Ankunftszeit bei der Tante");
Console.WriteLine("=========================================");
Console.WriteLine();

Console.Write("Entfernung in km: ");
string distanceInput = Console.ReadLine();
double distance = Convert.ToDouble(distanceInput); //100.00
Console.Write("Geschwindigkeit in km/h: ");
string velocityInput = Console.ReadLine();
double velocity = Convert.ToDouble(velocityInput); //25.00


double time = distance / velocity; //4.00
int fullHours = (int)time; //4
double remainingMinutes = (time - fullHours) * 60;//0-0=0 *60 = 0
int fullMinutes = (int)(remainingMinutes); //00
double remainingSeconds = (remainingMinutes - fullMinutes) * 60; //0 -0 * 60 = 0

fullHours += 10; 


Console.WriteLine("Für die Strecke von {0:f} km benötigen Sie {1:f5} Stunden.", distance, time);
Console.WriteLine("Sie kommen um {0}:{1:00}:{2:00} an.", fullHours, fullMinutes, remainingSeconds);