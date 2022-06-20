Console.WriteLine("Enter number for factorial :");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for(int i = number; i > 1; i--)
{
    factorial*= i;
}
Console.WriteLine(factorial);