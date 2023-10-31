List<int> firstNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> secondNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

List<int> output = new List<int>();



if (firstNumbers.Count > secondNumbers.Count)
{
    for (int index = 0; index <= firstNumbers.Count - 1; index++)
    {
        output.Add(firstNumbers[index]);

        for (int i = index; i <= secondNumbers.Count - 1; i++)
        {
            output.Add(secondNumbers[i]);
            break;
        }
    }
}
else
{
    int index = 0;
    while (index <= secondNumbers.Count - 1)
    {
        while (index <= firstNumbers.Count - 1)
        {
            output.Add(firstNumbers[index]);
            output.Add(secondNumbers[index]);
            index++;
            
        }
        output.Add(secondNumbers[index]);
        index++;
    }
}
Console.WriteLine(string.Join(" ", output));
