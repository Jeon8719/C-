using System.Text;

StringBuilder sb = new StringBuilder();
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
int N = int.Parse(sr.ReadLine());
int[] P = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
Array.Sort(P);
int time = 0;
while ( N !=0)
{
    for (int i = 0; i < N; i++)
    {
        time += P[i];
    }
    N--;
}
sb.AppendLine(time.ToString());
sw.Write(sb.ToString());
sr.Close();
sw.Close();

