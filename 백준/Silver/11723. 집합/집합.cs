
using System.Linq;
using System.Text;

StringBuilder sb = new StringBuilder();
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
int T = int.Parse(sr.ReadLine());
List<string> list = new List<string>();
for(int i = 0; i < T; i++)
{
    string[] M = sr.ReadLine().Split();
    switch (M[0])
    {
        case "add":
            if (list.Contains(M[1])) break;
            else list.Add(M[1]);
            break;
        case "remove":
            if (list.Contains(M[1])) list.Remove(M[1]); 
            else break;
            break;
        case "check":
            if (list.Contains(M[1])) sb.AppendLine("1");
            else sb.AppendLine("0");
            break;
        case "toggle":
            if (list.Contains(M[1])) list.Remove(M[1]);
            else list.Add(M[1]);
            break;
        case "all":
            list.Clear();
            for (int j = 1; j < 21; j++)
            {
                list.Add(j.ToString());
            }
            break;
        case "empty":
            list.Clear();
            break;
    }
}

sw.Write(sb.ToString());
sr.Close();
sw.Close();

