using System.ComponentModel.Design;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int finalResult = num1 * num2 * num3;
            bool isTrue = finalResult > 0;
            if (isTrue)
            {
                Console.WriteLine("positive");
            }
            else if (!isTrue && finalResult != 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }

    }
}