namespace LoopsExerciseTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            int newNumber = 1;
            
            while (power >= 1)
            {
                newNumber = newNumber * number;
                power--;
            }
            Console.WriteLine(newNumber);
        }
    }
}