int A = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < A; i++)
{
    for (int j = 0; j < A; j++)
    {
        if (j < i)
            Console.Write(" ");
        else
            Console.Write("*");


    }
    Console.WriteLine("");
}