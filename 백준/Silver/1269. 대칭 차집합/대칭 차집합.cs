using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();
        HashSet<int> num1 = new HashSet<int>();
        HashSet<int> num2 = new HashSet<int>();
        List<int> num3 = new List<int>();
        int count = 0;
        int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        for (int i = 0; i < a[0]; i++)
        {
            num1.Add(b[i]);
        }
        int[] c = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        for (int i = 0; i < a[1]; i++)
        {
            num2.Add(c[i]);
            if (!num1.Contains(c[i])) count++;
        }
        foreach (int i in num1)
        {
            if (!num2.Contains(i)) count++;
        }
        sb.Append(count);
        sw.Write(sb.ToString());
        sw.Close();
        sr.Close();
    }
}
