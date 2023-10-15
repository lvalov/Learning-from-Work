using System.Data;
using System.Data.Common;

namespace NestedLoopsTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int row = 1;
            int column = 1;


            while (column <= number)

            {
                int numberOfDigits = 0;
                while (numberOfDigits != row)
                {
                    Console.Write(column + " ");
                    column++;
                    numberOfDigits++;
                    if (column > number)
                    {
                        break;
                    }
                }
                row++;
                Console.WriteLine();
            }
        }
    }
}