using System;
StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
// 1 2 3 4 5
// 2 1 3 4 5
// 2 1 4 3 5
// 3 4 1 2 5
int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int[] c = new int[a[0]];
for (int i = 0; i < a[0]; i++)
{
    c[i] = 1 + i;
}
for (int i = 0; i < a[1]; i++)
{
    int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    Array.Reverse(c, b[0] - 1 , b[1] - b[0] + 1);

}
foreach (int i in c)
{
    sw.Write(i);
    sw.Write(' ');
}

sw.Close();
sr.Close();