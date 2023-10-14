namespace NestedLoopsTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string budget = Console.ReadLine();
            

            string command = "";
            double budget2 = double.Parse(budget);

            while (true)
            {
                double balance = 0.0;
                while (true)
                {
                    
                    command = Console.ReadLine();
                    double money = double.Parse(command);
                    balance += money;
                    Console.WriteLine($"Collected: {balance:f2}");

                    if (balance >= budget2)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                budget = (Console.ReadLine());
                budget2 = double.Parse(budget);
            }
        }
    }
}