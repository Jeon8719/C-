
using System.Text;

StringBuilder sb = new StringBuilder();
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
int T = int.Parse(sr.ReadLine());
if (T == 0) sb.AppendLine(0.ToString());
else
{
    List<int> list = new List<int>();
    for (int i = 0; i < T; i++)
    {
        list.Add(int.Parse(sr.ReadLine()));
    }
    list.Sort();
    int cutline = (int) Math.Round(T * 0.15, MidpointRounding.AwayFromZero);
    int sum = 0;
    for(int i = cutline; i < T-cutline ; i++)
    {
       sum += list[i];
    }    
    double answer = (double)sum / (T-(cutline *2));
    sb.AppendLine(Math.Round(answer, MidpointRounding.AwayFromZero).ToString());
    
}


sw.Write(sb.ToString());
sr.Close();
sw.Close();

