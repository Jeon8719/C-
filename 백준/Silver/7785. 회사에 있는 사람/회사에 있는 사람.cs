using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();
        int a = int.Parse(sr.ReadLine());

        SortedSet<string> c = new SortedSet<string>();

        for (int i = 0; i < a; i++)
        {
            
            string[] b = sr.ReadLine().Split(' ');
            if (b[1] == "leave")
            {
                c.Remove(b[0]);
            }
            else
            {
                c.Add(b[0]);
            }
        }
        List<string> d = c.Reverse().ToList();
        foreach (var item in d)
        {
            sb.AppendLine(item);
        }
        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
    }
}
