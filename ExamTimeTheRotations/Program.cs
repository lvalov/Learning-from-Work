List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int rotations = int.Parse(Console.ReadLine());
List<int> finalList = new List<int>();

for (int i = 1; i <= rotations; i++)
{
    int lastIndex = numbers.Count - 1;
    int lastElement = numbers[lastIndex];
    numbers.Insert(0, lastElement);
    
    if (i == 1)
    {
        numbers.RemoveAt(lastElement);
    }
    else
    {
        numbers.RemoveAt(lastIndex + 1);
    }
    
    finalList = numbers;
    
}
Console.WriteLine(string.Join(" ", numbers));