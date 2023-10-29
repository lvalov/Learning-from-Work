using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Xml;

namespace NestedLoopsTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int digit1 = 1; digit1 <= 9; digit1++)
            {
                for (int digit2 = 0; digit2 <= 9; digit2++)
                {
                    for (int digit3 = 0; digit3 <= 9; digit3++)
                    {
                        if (digit1 * digit2 * digit3 == n)
                        {
                            Console.Write($"{digit1}{digit2}{digit3} ");
                        }
                    }
                }
            }
        }
    }
}
for ()
{

}