using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Big Integer");
            Console.WriteLine("***********");

            string num1 = ReadBigInteger("Please enter 1. number: ");
            string num2 = ReadBigInteger("Please enter 2. number: ");

            string sum = AddBigInteger(num1, num2);
            string product = MultiplyBigIntegers(num1, num2);

            Console.WriteLine($"\nSumme:   {sum}");
            Console.WriteLine($"Product: {product}\n");

            Console.Write("Continue with \"y\": ");
            if (Console.ReadLine()?.ToLower() != "y") break;
        }
    }

    static string ReadBigInteger(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();
        } while (!IsValidBigInteger(input));
        return input;
    }

    static bool IsValidBigInteger(string str)
    {
        if (string.IsNullOrEmpty(str)) return false;

        for (int i = 0; i < str.Length; i++)
        {
            if (!char.IsDigit(str[i])) return false;
        }
        return true;
    }


    static string AddBigInteger(string num1, string num2)
    {
        int carry = 0;
        string result = "";

        int i = num1.Length - 1;
        int j = num2.Length - 1;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int digit1 = (i >= 0) ? num1[i] - '0' : 0;
            int digit2 = (j >= 0) ? num2[j] - '0' : 0;
            int sum = digit1 + digit2 + carry;

            carry = sum / 10;
            result = (sum % 10) + result;

            i--;
            j--;
        }
        return result;
    }

    static string MultiplyBigIntegerWithDigit(string num, int digit)
    {
        if (digit == 0) return "0";

        int carry = 0;
        string result = "";

        for (int i = num.Length - 1; i >= 0; i--)
        {
            int product = (num[i] - '0') * digit + carry;
            carry = product / 10;
            result = (product % 10) + result;
        }

        if (carry > 0) result = carry + result;
        return result;
    }

    static string MultiplyBigIntegers(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0") return "0";

        string result = "0";
        int numZeros = 0;

        for (int i = num2.Length - 1; i >= 0; i--)
        {
            string partialProduct = MultiplyBigIntegerWithDigit(num1, num2[i] - '0');
            partialProduct += new string('0', numZeros);
            result = AddBigInteger(result, partialProduct);
            numZeros++;
        }
        return result;
    }
}
