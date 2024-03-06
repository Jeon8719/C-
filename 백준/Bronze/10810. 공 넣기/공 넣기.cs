/// 0 0 0 0 0 
/// 3 3 
///     4 4
/// 1 1 1 1
///   2
/// 1 2 1 1 0


StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int[] c = new int[a[0]];

for (int i = 0; i < a[1]; i++)
{
    int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    for(int j = b[0]; j <= b[1]; j++)
    {
        c[j-1] = b[2];
        
    }
}
for(int i = 0;i < c.Length; i++)
{
    sw.Write(c[i]);
    sw.Write(' ');
}

sw.Close();
sr.Close();
