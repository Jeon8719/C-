using System;
using System.Collections.Generic;
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

        int N = int.Parse(sr.ReadLine());
        List<int> list = new List<int>();

        for (int i = 0; i < N; i++)
        {
            int A = int.Parse(sr.ReadLine());
            list.Add(A);
        }

        list.Sort();

        int average = (int)Math.Round((double)list.Sum() / N);
        sb.AppendLine(average.ToString());

        sb.AppendLine(list[N / 2].ToString());

        
        var groupedModes = list.GroupBy(v => v).OrderByDescending(g => g.Count());
        var maxCount = groupedModes.First().Count();
        var modes = groupedModes.TakeWhile(g => g.Count() == maxCount)
                                 .SelectMany(g => g.OrderBy(k => k))
                                 .Distinct();

        if (modes.Count() > 1)
        {
            modes = modes.Skip(1);
        }

        sb.AppendLine(modes.FirstOrDefault().ToString());

        sb.AppendLine((list.Max() - list.Min()).ToString());
        sw.WriteLine(sb.ToString());

        sr.Close();
        sw.Close();
    }
}
