using System.Text;

StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
StringBuilder sb = new StringBuilder();

int a = int.Parse(sr.ReadLine());
int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
Array.Sort(b);
int c = int.Parse(sr.ReadLine());
int[] d = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

for( int i = 0; i < c; i++ )
{
    int start = 0;
    int end = b.Length -1;
    bool isin = false;
    while( start <= end )
    {
        int mid = (start + end) / 2;
        int find = b[mid];
        if(find == d[i] )
        {
            isin = true;
            break;
        }
        if(find > d[i] )
        {
            end = mid - 1;
        }
        else
        {
            start = mid + 1;
        }    
    }
    if (isin) sb.Append(1 + " ");
    else sb.Append(0 + " ");
}
sw.WriteLine(sb.ToString());
sw.Close();
sr.Close();
