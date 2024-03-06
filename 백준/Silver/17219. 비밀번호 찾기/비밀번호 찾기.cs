using System.Text;

StringBuilder sb = new StringBuilder();
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
int[] NM = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
int N = NM[0];
int M = NM[1];
Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
for (int i = 0; i < N; i++)
{
    string[] sitepassward = sr.ReadLine().Split();
    keyValuePairs.Add(sitepassward[0], sitepassward[1]);
}
for (int i = 0;i < M; i++)
{
    string site = sr.ReadLine();
    keyValuePairs.TryGetValue(site, out string passward);
    sb.AppendLine(passward);
}
sw.Write(sb.ToString());
sr.Close();
sw.Close();

