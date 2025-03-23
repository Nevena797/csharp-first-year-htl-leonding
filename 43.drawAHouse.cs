using System;
using System.Drawing;

string title = "Draw a house";
int windowWidth = 80, windowHeight = 25, originalWidth, originalHeight;


static void WaitForKey()
{
    ConsoleColor originalColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Press any key to continue...");
    Console.ForegroundColor = originalColor;
    Console.ReadKey(true);
}


void SetWindowSize(int width, int height)
{
    Console.SetWindowSize(width, height);
}


void DrawPoint(int x, int y, ConsoleColor color = ConsoleColor.Gray)
{
    ConsoleColor originalColor = Console.ForegroundColor;
    Console.SetCursorPosition(x, windowHeight - y - 1);
    Console.ForegroundColor = color;
    Console.Write("*");
    Console.ForegroundColor = originalColor;
}


void DrawStraightLine(int startX, int startY, int endX, int endY, ConsoleColor color = ConsoleColor.Gray)
{
    int diffX = endX - startX;
    int diffY = endY - startY;
    int maxDistance = Math.Max(Math.Abs(diffX), Math.Abs(diffY));
    int offsetX = diffX >= 0 ? maxDistance / 2 : -maxDistance / 2;
    int offsetY = diffY >= 0 ? maxDistance / 2 : -maxDistance / 2;

    for (int i = 0; i <= maxDistance; i++)
    {
        int x = startX + (i * diffX + offsetX) / maxDistance;
        int y = startY + (i * diffY + offsetY) / maxDistance;
        DrawPoint(x, y, color);
    }
}


void DrawRectangle(int startX, int startY, int endX, int endY, ConsoleColor color = ConsoleColor.Gray)
{
    DrawStraightLine(startX, startY, endX, startY, color);
    DrawStraightLine(startX, endY, endX, endY, color);
    DrawStraightLine(startX, startY, startX, endY, color);
    DrawStraightLine(endX, startY, endX, endY, color);
}


void DrawFilledRectangle(int startX, int startY, int endX, int endY, ConsoleColor color = ConsoleColor.Gray)
{
    for (int y = startY; y <= endY; y++)
    {
        DrawStraightLine(startX, y, endX, y, color);
    }
}


void DrawWindow(int startX, int startY, int endX, int endY, ConsoleColor color = ConsoleColor.Gray)
{
    DrawRectangle(startX, startY, endX, endY, color);
    DrawStraightLine((startX + endX) / 2, startY, (startX + endX) / 2, endY, color);
    DrawStraightLine(startX, (startY + endY) / 2, endX, (startY + endY) / 2, color);
}


void DrawDoor(int startX, int startY, int endX, int endY, ConsoleColor color = ConsoleColor.Gray)
{
    DrawRectangle(startX, startY, endX, endY, color);
    DrawStraightLine((startX + endX) / 2, startY, (startX + endX) / 2, endY, color);
}


void DrawHouse(int startX, int startY, int endX, int endY, ConsoleColor color = ConsoleColor.Gray)
{
    DrawRectangle(startX, startY, endX, endY, color);
    DrawStraightLine(startX - 2, endY - 1, (startX + endX) / 2, endY + (endY - startY - 1), color);
    DrawStraightLine((startX + endX) / 2 + 1, endY + (endY - startY - 1), endX + 2, endY - 1, color);

    DrawWindow(startX + 3, endY - 2, (startX + endX) / 2 - 1, (startY + endY) / 2 + 1);
    DrawWindow((startX + endX) / 2 + 2, endY - 2, endX - 3, (startY + endY) / 2 + 1);
    DrawWindow((startX + endX) / 2 + 2, startY + 2, endX - 3, (startY + endY) / 2 - 1);
    DrawDoor(startX + 3, startY + 1, (startX + endX) / 2 - 1, (startY + endY) / 2 - 1, ConsoleColor.Red);
}


void DrawSingleHouse(int x, int y, ConsoleColor color = ConsoleColor.Gray)
{
    DrawHouse(x, y, x + 17, y + 10, color);
}


Console.WriteLine($"***{new string('*', title.Length + 5)}**");
Console.WriteLine($"*  {title.PadRight(title.Length + 5, ' ')} *");
Console.WriteLine($"*  {new string(' ', title.Length + 5)} *");
Console.WriteLine($"***{new string('*', title.Length + 5)}**\n\n");

WaitForKey();

Console.Clear();
originalWidth = Console.WindowWidth;
originalHeight = Console.WindowHeight;

SetWindowSize(windowWidth, windowHeight);

DrawStraightLine(0, 0, windowWidth - 1, 0, ConsoleColor.Green);
DrawSingleHouse(5, 1, ConsoleColor.White);
DrawSingleHouse(30, 2, ConsoleColor.Magenta);
DrawSingleHouse(55, 3, ConsoleColor.Yellow);

Console.SetWindowSize(originalWidth, originalHeight);
Thread.Sleep(50);

Console.SetCursorPosition(20, 25);

WaitForKey();

