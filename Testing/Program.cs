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
Console.WriteLine(FindTheSumOfDigits(15));



