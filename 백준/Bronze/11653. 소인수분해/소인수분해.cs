int a = int.Parse(Console.ReadLine());
int b = 2;
List<int> c = new List<int>();
if (a != 1)
{
    while (a / b != 0)
    {
        if (a % b == 0)
        {
            a /= b;
            c.Add(b);
        }
        else b++;
    }
    c.Sort();
    for (int i = 0; i < c.Count; i++)
    {
        Console.WriteLine(c[i]);
    }
}