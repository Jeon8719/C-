bool[] a = new bool[31];
for (int i = 0; i < 28; i++)
{
    int n = int.Parse(Console.ReadLine());
    a[n] = true;
}
for (int i = 1; i < 31; i++)
{
    if (!a[i])
        Console.WriteLine(i);
}