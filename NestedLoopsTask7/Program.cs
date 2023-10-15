using System.Diagnostics.CodeAnalysis;

namespace NestedLoopsTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string command = "";
           

            while (command != "End")
            {
                command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                int number = int.Parse(command);
                int sum = 0;
                while (number > 0)
                {
                    
                    sum += number % 10;
                    number = number / 10;
                }
                Console.WriteLine($"Sum of digits = {sum}");
            }
            Console.WriteLine("Goodbye");
        }
    }
}