using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();       
        int N = int.Parse(sr.ReadLine());
        sb.Append(N*(N-1));

        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
    }
}
