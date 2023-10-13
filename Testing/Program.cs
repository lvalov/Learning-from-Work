using System;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        for (int row = 1; row <= size; row++)
        {
            //Console.WriteLine("*");
            for (int col = 1; col <= row; col++)
            { 
                Console.Write("*");
            }
            Console.WriteLine();
        }
        

    }
}
 