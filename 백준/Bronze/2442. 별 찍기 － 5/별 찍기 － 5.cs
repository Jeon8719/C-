int A = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < A; i++)
{
    for (int j = A - i - 1; j > 0; j--)
    {
        Console.Write(" ");

    }
    for (int k = 0; k < 2 * i + 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();

}