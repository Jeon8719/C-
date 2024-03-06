int a = int.Parse(Console.ReadLine());
// 5x + 3y = a;
List<int>d = new List<int>();
for (int b = 0; b < a; b++)
{
    for(int c = 0; c < a; c++)
    {
        if (5 * b + 3 * c == a || 5 * b == a || 3 * c == a)
        {
            d.Add(b + c);
        }
    }
}
if (d.Count == 0)
{
    Console.WriteLine(-1);
}
else
{
    Console.WriteLine(d.Min());
}

