using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();

        int n = int.Parse(sr.ReadLine());
        List<int> list = new List<int>();

        for (int i = 0; i < n; i++)
        {
            list.Add(int.Parse(sr.ReadLine()));
        }

        int gcd = GCD(list[1] - list[0], list[2] - list[1]);

        for (int i = 1; i < n - 1; i++)
        {
            gcd = GCD(gcd, list[i + 1] - list[i]);
        }

        int b = (list[n - 1] - list[0]) / gcd - n + 1;
        sb.AppendLine(b.ToString());

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
