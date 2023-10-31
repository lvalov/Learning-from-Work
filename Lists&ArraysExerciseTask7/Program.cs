using System.Globalization;

int rows = int.Parse(Console.ReadLine());

int stop  = 0;
int currentRow = 1;
List<int> firstList = new List<int>();
List<int> secondList = new List<int>();

while (stop < rows)
{
    List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
    
    for (int i = 0; i <= numbers.Count - 1; i++)
    {
        if (i == 0 && currentRow % 2 == 1)
        {
            firstList.Add(numbers[i]);
        }
        if (i == 1 && currentRow % 2 == 1)
        {
            secondList.Add(numbers[i]);
        }
        if (i == 0 && currentRow % 2 == 0)
        {
            secondList.Add(numbers[i]);
        }
        if (i == 1 && currentRow % 2 == 0)
        {
            firstList.Add(numbers[i]);
        }
        
    }
    currentRow++;
    stop++;
}
Console.WriteLine(string.Join(" ", firstList));
Console.WriteLine(string.Join(" ", secondList));