using System.Text;

StringBuilder sb = new StringBuilder();
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
int T = int.Parse(sr.ReadLine());
int[,] fibo = new int[41, 2];
fibo[0, 0] = 1;
fibo[1, 1] = 1;
for (int j = 2; j < 41; j++)
{
    fibo[j, 0] = fibo[j - 1, 0] + fibo[j - 2, 0];
    fibo[j, 1] = fibo[j - 1, 1] + fibo[j - 2, 1];
}
for (int k = 0; k < T; k++)
{
    int index = int.Parse(sr.ReadLine());
    sb.AppendLine(fibo[index, 0] + " " + fibo[index, 1]);
}
sw.Write(sb.ToString());
sr.Close();
sw.Close();
