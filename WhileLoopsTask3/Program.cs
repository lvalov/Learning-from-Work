namespace WhileLoopsTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int startingNumber = 0;
            while (startingNumber < num)
            {
                startingNumber =  startingNumber * 2 + 1;
                Console.WriteLine(startingNumber);
            }
            
        }
    }
}