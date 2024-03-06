int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

if (a[1] - 45 < 0)
{
    aresult();
    Console.WriteLine($"{a[0] - 1} {60 - Math.Abs(a[1] - 45)}");
}
else
{
    Console.WriteLine($"{a[0]} {(a[1] - 45)}");
}
    


void aresult()
{
    if (a[0] >= 24) a[0] = 0;
    if (a[0] <= 0) a[0] = 24;

}