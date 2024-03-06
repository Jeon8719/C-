using System.Text;

StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
StringBuilder sb = new StringBuilder();

int a = int.Parse(sr.ReadLine());
string[] b = sr.ReadLine().Split();
int[] c = new int[a];
for( int i = 0; i < a; i++ )
{
    c[i] = int.Parse(b[i]);
}
int[] d = c.Distinct().ToArray();
Array.Sort(d);
foreach( int i in c )
{
    sb.Append(lower_bound(d,i,d.Length) + " ");
}
static int lower_bound(int[] num, int target, int n)
{
    int start = 0;
    int end = n - 1;
    while (start < end)
    {
        int mid = (start + end) / 2;
        if (num[mid] >= target)
        {
            end = mid;
        }
        else
        {
            start = mid + 1;
        }
    }
    return end;
}
sw.WriteLine(sb.ToString());
sr.Close();
sw.Close();
