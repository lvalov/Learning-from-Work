string password = Console.ReadLine();
bool isValidLenght = password.Length >= 6 && password.Length <= 10;
if ()
{
    Console.WriteLine("Password is valid");
}
else
{
    if (!isValidLenght)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }
    if ()
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }
    if ()
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}