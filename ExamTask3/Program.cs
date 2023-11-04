using System.Xml;

static bool IsPrime(int number)
{
    if (number <= 1)
        return false;

    if (number <= 3)
        return true;

    if (number % 2 == 0 || number % 3 == 0)
        return false;

    for (int i = 5; i * i <= number; i += 6)
    {
        if (number % i == 0 || number % (i + 2) == 0)
            return false;
    }

    return true;
}
static int FindTheSumOfDigits(int number)
{
    int sumOfDigits = 0;

    while (number > 0)
    {
        int result = number % 10;
        sumOfDigits += result;
        number = number / 10;
    }
    return sumOfDigits;
}
static bool FindIfAllDigitsArePrime(int number)
{
    while (number > 0)
    {
        int result = number % 10;
        if (IsPrime(result) == true)
        {
            continue;
        }
        else
        {
            break;
        }
        number = number / 10;
    }
    return true;
}








int n = int.Parse(Console.ReadLine());



for  (int i = 1;  i <= n; i++)
{
    if (FindIfAllDigitsArePrime(i) && FindTheSumOfDigits(i) % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
