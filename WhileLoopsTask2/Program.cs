namespace WhileLoopsTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            while (number % 2 == 0)
            {
               
               int newNumber = int.Parse(Console.ReadLine());
               number = newNumber;
            }
            Console.WriteLine(number);
        }
    }
}