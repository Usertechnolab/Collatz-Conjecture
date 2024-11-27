Console.WriteLine("Please input a number");
int number = int.Parse(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("Invalid input data");
}
else
{
    Console.WriteLine("Collatz Conjecture:");
    while (number != 1)
    {
        Console.WriteLine(number);
        if (number % 2 == 0)
        {
            number = number / 2;
        }
        else
        {
            number = (number * 3) + 1;
        }
    }
    Console.WriteLine(number);
}
Console.ReadLine();
