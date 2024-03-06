int b = int.Parse(Console.ReadLine());
int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int d = 0;
for (int i = 0; i < b; i++) 
{
    if (a[i] != 0 && a[i] != 1)
    {
        int c = 0;
        for(int j = 1; j <= a[i]; j++)
        {
            if (a[i] % j == 0) c++;
        }
        if (c == 2) d++;
    }
}
Console.WriteLine(d);

