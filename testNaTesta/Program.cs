using System.ComponentModel.Design;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //int currNumber = 0;
            for (int newNumber; newNumber % 2 == 0; newNumber++)
            {

                int newNumber = int.Parse(Console.ReadLine());
                number = newNumber;
            }
            Console.WriteLine(number);
        }
        
    }
}