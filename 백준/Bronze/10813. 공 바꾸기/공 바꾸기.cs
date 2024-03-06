//1 2 3 4 5
//2 1 3 4 5
//2 1 4 3 5
//3 1 4 2 5


StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int[] c = new int[a[0]];
for( int i = 0; i < a[0]; i++ )
{
    c[i] = i+1;
}
for (int i = 0; i < a[1]; i++)
{
    int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    int d = c[b[0] - 1];
    c[b[0] - 1] = c[b[1] - 1];
    c[b[1] - 1] = d;
}
for (int i = 0; i < c.Length; i++)
{
    sw.Write(c[i]);
    sw.Write(' ');
}

sw.Close();
sr.Close();