int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(b);
List<int> list = new List<int>();
for (int i = 0; i < a[0]; i++)
{
    for (int j = i+1; j < a[0]; j++)
    {
        for (int k = j+1; k < a[0]; k++)
        {
            int c = b[i] + b[j] + b[k];
            if (c <= a[1]) list.Add(c);
        }
    }
}
Console.WriteLine(list.Max());