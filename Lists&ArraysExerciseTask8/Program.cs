using System.Threading.Tasks.Dataflow;

List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int rotations = int.Parse(Console.ReadLine());
List<int> finalList = new List<int>();

for (int i = 1; i <= rotations; i++)
{
    numbers.Insert(numbers.Count, numbers[0]);
    numbers.RemoveAt(0);
    finalList = numbers;
}
Console.WriteLine(string.Join(" ", finalList));
