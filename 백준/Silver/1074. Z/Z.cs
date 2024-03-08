using System.Text;

StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StringBuilder sb = new StringBuilder();
int[] Nrc = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);


int sol(int a, int b, int c)
{
    if (a == 0) return 0;
    return 2 * (b % 2) + (c % 2) + 4 * sol(a - 1, b / 2, c / 2);
}

sb.AppendLine(sol(Nrc[0], Nrc[1], Nrc[2]).ToString());

sw.WriteLine(sb.ToString());
sw.Close();
sr.Close();

