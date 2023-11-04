List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

double sum = 0;

for  (int i = 0; i <= numbers.Count -1; i++)
{
    sum += numbers[(numbers.Count - 1) / 2];
    sum += numbers[numbers.Count / 2];
    break;
}
Console.WriteLine($"{sum / 2:F2}");