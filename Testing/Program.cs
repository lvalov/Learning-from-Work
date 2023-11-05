using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Read the first row of input as a list of integers separated by space
        //Console.Write("Enter a list of integers separated by space: ");
        string inputRow1 = Console.ReadLine();
        int[] numbers = inputRow1.Split(' ').Select(int.Parse).ToArray();

        // Read the second row of input as the number of rotations
        //Console.Write("Enter the number of rotations: ");
        int rotations = int.Parse(Console.ReadLine());

        // Perform the rotations
        RotateList(numbers, rotations);

        // Display the result
        Console.WriteLine(string.Join(", ", numbers));
    }

    static void RotateList(int[] numbers, int rotations)
    {
        for (int i = 0; i < rotations; i++)
        {
            int lastElement = numbers[numbers.Length - 1];

            for (int j = numbers.Length - 1; j > 0; j--)
            {
                numbers[j] = numbers[j - 1];
            }

            numbers[0] = lastElement;
        }
    }
}