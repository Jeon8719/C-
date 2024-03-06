using System.Text;
class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();
        long a = long.Parse(sr.ReadLine());
        long b = 0;
        while (b*b <= a) b++;
        sb.Append(b-1);
        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
    }
}
