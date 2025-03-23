using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Find HTL Leonding Numbers");
        Console.WriteLine("****************************");

        Console.Write("Calculate until: ");
        int limit;
        while (!int.TryParse(Console.ReadLine(), out limit) || limit <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            Console.Write("Calculate until: ");
        }

        Console.WriteLine("****************************");

        List<int> htlNumbers = FindHTLLeondingNumbers(limit);
        PrintNumbers(htlNumbers);
    }

    // Methode zur Überprüfung, ob eine Zahl eine HTL-Leonding-Zahl ist
    static bool IsHTLLeondingNumber(int number)
    {
        if (number % 2 == 0) return false; // Muss ungerade sein

        int digitSum = CalculateDigitSum(number);
        if (digitSum <= 10) return false; // Ziffernsumme muss > 10 sein

        for (int x = number - 1; x > 0; x--)
        {
            if (CalculateDigitSum(x) == digitSum)
            {
                int ggt = CalculateGCD(number, x);
                if (IsPrime(ggt)) return true;
            }
        }

        return false;
    }

    // Berechnet die Ziffernsumme einer Zahl (ohne Strings)
    static int CalculateDigitSum(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    // Berechnet den größten gemeinsamen Teiler (GGT) mit dem Euklidischen Algorithmus
    static int CalculateGCD(int a, int b)
    {
        int c;
        while (b != 0)
        {
            c = a % b;
            a = b;
            b = c;
        }
        return a;
    }

    // Überprüft, ob eine Zahl eine Primzahl ist
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    // Sucht alle HTL-Leonding-Zahlen bis zur Obergrenze
    static List<int> FindHTLLeondingNumbers(int limit)
    {
        List<int> result = new List<int>();
        for (int i = 1; i <= limit; i++)
        {
            if (IsHTLLeondingNumber(i))
            {
                result.Add(i);
            }
        }
        return result;
    }

    // Gibt die HTL-Leonding-Zahlen in Zeilen von je 10 Zahlen aus
    static void PrintNumbers(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i]);
            if ((i + 1) % 10 == 0 || i == numbers.Count - 1)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("****************************");
    }
}
