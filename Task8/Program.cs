namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            //if (num >= 100 && num <= 200 || num == 0)
            //{
            //    Console.WriteLine(" ");
            //}
            //else
            //{
            //    Console.WriteLine("invalid");
            //}

            bool isTrue = num >= 100 && num <= 200 || num == 0;

            if (!isTrue)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}