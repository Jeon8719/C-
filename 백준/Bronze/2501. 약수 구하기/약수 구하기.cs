int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
List<int> b = new List<int>();  
for(int i = 1; i <= a[0]; i++)
{
    if (a[0] % i == 0)
    {
        b.Add(i);
    }
}
if (b.Count < a[1])
{
    Console.WriteLine(0);
}
else Console.WriteLine(b[a[1]-1]);