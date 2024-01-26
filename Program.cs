for (int i = 1; i < 101; i++)
{
    double divisible = i % 3;
    double divisible2 = i % 5;
    double total = divisible + divisible2;
    if (total == 0)
    {
        Console.WriteLine(i + " - FizzBuzz");
    } else if (divisible == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    } else if (divisible2 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
    
    
}
