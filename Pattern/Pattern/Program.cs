Console.WriteLine("Enter number of line for pattern 1");
int patternOneNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter even number of line for pattern 2");
int patternTwoNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Printing pattern 1 :");
for (int i = 0; i < patternOneNumber; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine(" \n\nPrinting pattern 2 :");
int maxStars = patternTwoNumber / 2;
for (int i = 0; i < maxStars; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for (int i = maxStars; i > 0; i--)
{
    for (int j = i; j > 0; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
