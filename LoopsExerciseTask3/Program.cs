using System.Security;

namespace LoopExerciseTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            int biggestNumber = int.MinValue;
            

            for (int i = 1; i <= numberCount; i++)
            {
                int currentNumber = 0;
                int newNumber = int.Parse(Console.ReadLine());
                currentNumber += newNumber;

                if (currentNumber >= biggestNumber)
                {
                    biggestNumber = currentNumber;
                }
                else if (currentNumber <= biggestNumber)
                {
                    biggestNumber = biggestNumber;
                }
            }
            Console.WriteLine(biggestNumber);
        }
    }
}