double numberOfStudents = double.Parse(Console.ReadLine());
double totalSum = 0;
for (int i = 0; i < numberOfStudents; i++)
{
    double grade = double.Parse(Console.ReadLine());

    totalSum += grade;

}
Console.WriteLine($"{totalSum / numberOfStudents:F2}");