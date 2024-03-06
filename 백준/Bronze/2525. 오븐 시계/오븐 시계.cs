int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = int.Parse(Console.ReadLine());

int c = a[1] + b % 60;
int d = a[0] + b / 60;
if (c >= 60)
{
    c -= 60;
    d++;
}
if (d >= 24)
{
    d -= 24;
}
Console.WriteLine($"{d} {c}");
