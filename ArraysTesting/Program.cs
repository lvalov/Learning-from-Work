int[] firstNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondNumber = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


for  (int index = 0; index <= firstNumbers.Length - 1; index++)
{
    if (firstNumbers[index] != secondNumber[index])
    {
        Console.WriteLine("Arrays are not identical.");
        break;
    }
    else
    {
        Console.WriteLine("Arrays are identical.");
    }
}
