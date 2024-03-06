int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = new int[5];
for (int i = 0; i < 5; i++)
{
    b[i] = a[i] * a[i];
}
Console.WriteLine((b[0] + b[1] + b[2] + b[3] + b[4])%10);
