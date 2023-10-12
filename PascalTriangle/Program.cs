using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows for Pascal's Triangle: ");
        if (int.TryParse(Console.ReadLine(), out int numRows) && numRows >= 1)
        {
            PrintPascalsTriangle(numRows);
        }
        else
        {
            Console.WriteLine("Please enter a valid positive integer.");
        }
    }

    static void PrintPascalsTriangle(int numRows)
    {
        for (int i = 0; i < numRows; i++)
        {
            int currentValue = 1;

            // Print leading spaces for alignment
            for (int j = 0; j < numRows - i; j++)
            {
                Console.Write("   ");
            }

            // Print values for the current row
            for (int j = 0; j <= i; j++)
            {
                Console.Write($"{currentValue,6}   ");
                currentValue = currentValue * (i - j) / (j + 1);
            }

            Console.WriteLine(); // Move to the next line for the next row
        }
    }
}
