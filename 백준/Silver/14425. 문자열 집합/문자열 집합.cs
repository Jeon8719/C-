using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();

        int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        HashSet<string> b = new HashSet<string>();
        string[] c = new string[a[1]];
        int d = 0; 
        for (int i = 0; i < a[0]; i++)
        {
            b.Add(sr.ReadLine());
        }

        for (int i = 0; i < a[1]; i++)
        {
            string s = sr.ReadLine();
            if (b.Contains(s)) d++;
        }
        sw.WriteLine(d);
        sw.Close();
        sr.Close();
    }
}
