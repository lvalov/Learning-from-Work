namespace CollatzConjecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCount = 0;

            while (number > 1)
            {
                int nextNumber = 0;
                if (number % 2 == 0)
                {
                    nextNumber = number / 2;
                }
                else if (number % 2 == 1)
                {
                    nextNumber = 3 * number + 1;
                }
                number = nextNumber;
                numberCount++;
                Console.WriteLine(number);
            }
            Console.WriteLine($"Total steps taken = {numberCount}");
        }
    }
}