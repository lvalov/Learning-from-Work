namespace LoopExercisesTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sumTotal = 0;

            for (int i = 1; i <= count; i++)
            { 
              char leter = char.Parse(Console.ReadLine());

                if (leter == 'a')
                {
                    sumTotal += 1;
                }
                else if (leter == 'e')
                {
                    sumTotal += 2;
                }
                else if (leter == 'i')
                {
                    sumTotal += 3;
                }
                else if (leter == 'o')
                {
                    sumTotal += 4;
                }
                else if (leter == 'u')
                {
                    sumTotal += 5;
                }
                else
                {
                    sumTotal += 0;
                }

            }
            Console.WriteLine(sumTotal);
        }
    }
}