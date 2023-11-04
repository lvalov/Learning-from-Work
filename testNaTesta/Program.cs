  int result = CalculateFactorial(4);
  Console.WriteLine(result);

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