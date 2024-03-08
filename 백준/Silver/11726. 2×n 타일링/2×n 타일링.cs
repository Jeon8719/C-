using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StringBuilder sb = new StringBuilder();

        int n = int.Parse(sr.ReadLine());
        const int MOD = 10007;
        int[] dp = new int[1001];
        dp[0] = 1;
        dp[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            dp[i] = (dp[i - 1] + dp[i - 2]) % MOD;
        }

        sb.AppendLine(dp[n].ToString());

        sw.Write(sb.ToString());
        sw.Flush();
        sw.Close();
        sr.Close();
    }
}
