using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();       
        int N = int.Parse(sr.ReadLine());
        double answer = Math.Pow(2,N);
  
        sb.Append(answer);
        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
    }
}
