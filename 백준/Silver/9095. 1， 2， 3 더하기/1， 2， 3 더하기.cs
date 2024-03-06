using System.Text;

StringBuilder sb = new StringBuilder();
int T = int.Parse(Console.ReadLine()); 
int[] dp = new int[11]; 


dp[0] = 1; 
dp[1] = 1; 
dp[2] = 2; 

for (int i = 3; i <= 10; i++)
{
    dp[i] = dp[i - 1] + dp[i - 2] + dp[i - 3];
}

for (int i = 0; i < T; i++)
{
    int n = int.Parse(Console.ReadLine());
    sb.AppendLine(dp[n].ToString());
}
Console.WriteLine(sb.ToString());