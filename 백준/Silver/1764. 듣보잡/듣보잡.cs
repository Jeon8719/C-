using System;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();
        HashSet<string> person1 = new HashSet<string>();
        HashSet<string> person2 = new HashSet<string>();
        int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        for(int i = 0 ; i < a[0]; i++)
        {
            string b = sr.ReadLine();
            person1.Add(b);
        }
        for(int i = 0; i < a[1]; i++)
        {
            string b = sr.ReadLine();
            if (person1.Contains(b)) person2.Add(b);
        }
        List<string> person3 = person2.OrderBy(x => x).ToList();
        sb.AppendLine(person3.Count().ToString());
        for (int i = 0;i < person2.Count; i++)
        {
            sb.AppendLine(person3[i].ToString());
        }
        sw.Write(sb.ToString());
        sw.Close();
        sr.Close();
    }
}
