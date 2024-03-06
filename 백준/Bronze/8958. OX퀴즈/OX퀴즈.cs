using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();

        int t = int.Parse(sr.ReadLine());
        int b = 0;
        int c = 0;
        for (int i = 0; i < t; i++)
        {
            char[] a = sr.ReadLine().ToCharArray();
            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] == 'O')
                {
                    b++;
                    c += b;
                }
                else
                {
                    b = 0;
                }

            }
            sb.AppendLine(c.ToString());
            c = 0;
            b = 0;
        }

        sw.Write(sb.ToString());
        sw.Close();
        sr.Close();
    }
}
