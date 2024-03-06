using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();

        char[] a = sr.ReadLine().ToCharArray();
        List<string> c = new List<string>();

        for (int i = 0; i < a.Length; i++)
        {
            StringBuilder currentSubstring = new StringBuilder();


            for (int j = i; j < a.Length; j++)
            {
                currentSubstring.Append(a[j]);
                c.Add(currentSubstring.ToString());
            }
        }


        c = c.Distinct().ToList();

        sb.Append(c.Count);
        sw.Write(sb.ToString());

        sw.Close();
        sr.Close();
    }
}
