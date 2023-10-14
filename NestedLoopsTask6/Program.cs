using System.Data;
using System.Data.Common;

namespace NestedLoopsTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());

            int rows = 1;
            int columns = 1;
            while (rows <= number)
            {
                
                while (columns >= rows)
                {
                    columns++;
                    Console.Write(rows);
                    
                }
                rows++;


                Console.WriteLine();
            }
        }
    }
}