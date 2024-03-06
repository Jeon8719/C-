using System.Text;

StringBuilder sb = new StringBuilder();
StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

int t = Convert.ToInt32(sr.ReadLine());
for (int i = 0; i < t; i++)
{
    int[] arry = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    int ans = arry[0] + arry[1];
    sb.AppendLine(ans.ToString());
}
sw.Write(sb);
sw.Close();
sr.Close();