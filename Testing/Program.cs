using System;

class Program
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());

        double result = Math.Pow(number, power);
        Console.WriteLine(result);
    }
}
