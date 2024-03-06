using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();
        int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        int c = a[0] * b[1] + a[1] * b[0];
        int d = a[1] * b[1];
        sb.Append(($"{c / GCD(c, d)} {d / GCD(c, d)}").ToString());
        sw.WriteLine(sb.ToString());
        sr.Close();
        sw.Close();

        int GCD(int a, int b)
        {
            while (b != 0)
            {
                int c = b;
                b = a % b;
                a = c;
            }
            return a;
        }
    }
}
