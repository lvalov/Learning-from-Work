static int CalculateFactorial(int number)
{
    int result = 1;

    while (number > 0)
    {
        result = result * number;
        number--;
    }
    return result;

}


int number = int.Parse(Console.ReadLine());

int sum = 0;


while (number != 0)

{
    int digit = number % 10;
    number = number / 10;
    if (digit % 2 == 0)
    {

        sum += CalculateFactorial(digit);
    }
    else if (digit % 2 == 1)
    {
        continue;
    }

}
Console.WriteLine(sum);
