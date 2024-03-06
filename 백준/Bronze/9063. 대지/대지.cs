int a = int.Parse(Console.ReadLine());
int[] c = new int[a];
int[] d = new int[a];
for(int i = 0; i < a; i++)
{
    int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    c[i] = b[0];
    d[i] = b[1];
}
Console.WriteLine((c.Max() - c.Min()) * (d.Max() - d.Min()));