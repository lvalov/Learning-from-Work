namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerOne = int.Parse(Console.ReadLine());  
            int playerTwo = int.Parse(Console.ReadLine());
            int playerThree = int.Parse(Console.ReadLine());

            int totalTime = playerOne + playerTwo + playerThree;

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":" + "0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
        }
    }
}