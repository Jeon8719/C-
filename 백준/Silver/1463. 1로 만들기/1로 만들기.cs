//1463번
using System.Text;

StringBuilder sb = new StringBuilder();
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

int X = int.Parse(sr.ReadLine());
int[] dp = new int[1000001];
dp[0] = dp[1] = 0;
for (int i = 2; i <= X; i++)
{
    dp[i] = dp[i - 1] + 1;
    if (i % 2 == 0) dp[i] = Math.Min(dp[i], dp[i / 2] + 1);
    if (i % 3 == 0) dp[i] = Math.Min(dp[i], dp[i / 3] + 1);
}
sb.AppendLine(dp[X].ToString());
sw.Write(sb.ToString());
sr.Close();
sw.Close();
