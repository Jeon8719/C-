using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Test
{
    public string Name { get; set; }
    public int Length { get; set; }
    public int Count { get; set; }
}

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();

        int[] N = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        var result = new Dictionary<string, Test>();

        for (int i = 0; i < N[0]; i++)
        {
            string s = sr.ReadLine();

            // 이미 등록된 단어인지 확인
            if (result.TryGetValue(s, out var existingTest))
            {
                // 등록된 단어면 Count 증가
                existingTest.Count++;
            }
            else if (s.Length >= N[1])
            {
                // 등록되지 않은 단어면 새로 추가
                result[s] = new Test { Name = s, Length = s.Length, Count = 1 };
            }
        }

        // Count가 높은 순으로 정렬하고 Length가 높은 순으로 정렬 후 
        var sortedResult = result.Values.OrderByDescending(t => t.Count)
                                .ThenByDescending(t => t.Length)
                                .ThenBy(t => t.Name, StringComparer.Ordinal);

        foreach (var test in sortedResult)
        {
            sb.AppendLine($"{test.Name}");
        }

        sw.WriteLine(sb.ToString());

        sr.Close();
        sw.Close();
    }
}
