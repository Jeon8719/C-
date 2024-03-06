int A = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < A; i++)
{
    for (int j = A; j > 0; j--)
    {
        if (j < i+1)
            Console.Write("");
        else
            Console.Write("*");

    }
    Console.WriteLine("");
}