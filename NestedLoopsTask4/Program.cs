namespace NestedLoopsTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int estates = int.Parse(Console.ReadLine());

            for (int i = floors;  i >= 1; i--) 
            {

                for (int j = 1; j <= estates; j++)
                {
                    if (i % 2 == 0 && i != floors)
                    {
                        Console.Write($"O{(i * 10 - 1) + j} ");
                    }
                    if (i % 2 == 1 && i != floors)
                    {
                        Console.Write($"A{(i * 10 - 1) + j} ");
                    }
                    if (i == floors)
                    {
                        Console.Write($"L{(i * 10 - 1) + j} ");
                    }
                }
                Console.WriteLine();
            }
            

        }
    }
}