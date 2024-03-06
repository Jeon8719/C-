int a = int.Parse(Console.ReadLine());


for (int i = 0; i < a; i++)
{
    for (int j = a - 1; j > i; j--)
    {
        Console.Write(" ");
    }
    for (int k = 0; k <= i; k++)
    {
        Console.Write("*");
    }
    for (int l = 0; l <= i - 1; l++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for (int i = 0; i < a - 1; i++)
{
    for (int j = 0; j < i+1; j++)
    {
        Console.Write(" ");
    }
    for (int k = a-1; k > i; k--)
    {
        Console.Write("*"); 
    }
    for (int k = a-2; k > i; k--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}