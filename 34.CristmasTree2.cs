using System;

class Program
{
    static void Main()
    {
        int height;

        // Keep asking for input until valid
        while (true)
        {
            Console.Write("Please enter the height: ");
            if (int.TryParse(Console.ReadLine(), out height) && height > 0)
                break;
        }

        // Counter for Q replacements (every 7th x)
        int xCounter = 0;

        // Draw the tree
        for (int row = 0; row < height - 1; row++)
        {
            // Calculate spaces before the x's
            int spaces = height - row - 2;

            // Print leading spaces
            for (int i = 0; i < spaces; i++)
            {
                Console.Write(" ");
            }

            // Calculate number of x's for this row
            int xCount = 2 * row + 1;

            // Print the x's and Q's
            for (int i = 0; i < xCount; i++)
            {
                xCounter++;
                if (xCounter % 7 == 0)
                {
                    Console.Write("Q");
                }
                else
                {
                    Console.Write("x");
                }
            }

            Console.WriteLine();
        }

        // Draw the trunk (last line)
        for (int i = 0; i < height - 2; i++)
        {
            Console.Write(" ");
        }
        xCounter++;
        Console.WriteLine(xCounter % 7 == 0 ? "Q" : "x");
    }
}
