using System.Text;
StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
StringBuilder sb = new StringBuilder();

int a = int.Parse(sr.ReadLine());
List<int> b = new List<int>();
for (int i = 0; i < a; i++)
{
    int c = int.Parse(sr.ReadLine());
    b.Add(c);
}
b.Sort();
for (int i = 0; i < b.Count; i++)
{
    sb.AppendLine(b[i].ToString());
}
sw.WriteLine(sb.ToString());
sr.Close();
sw.Close();