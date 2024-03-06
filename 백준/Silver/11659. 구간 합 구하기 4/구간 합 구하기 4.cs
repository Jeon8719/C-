using System;
using System.IO;
using System.Text;

class MainClass
{
    static void Main(string[] args)
    {
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        StreamReader sr = new StreamReader(Console.OpenStandardInput());
        StringBuilder sb = new StringBuilder();

        string[] input1 = sr.ReadLine().Split();
        int N = int.Parse(input1[0]);
        int M = int.Parse(input1[1]);

        int[] array = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
        
        int[] prefixSum = new int[N + 1];
        for (int i = 1; i <= N; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + array[i - 1];
        }

        for (int i = 0; i < M; i++)
        {
            string[] input2 = sr.ReadLine().Split();
            int start = int.Parse(input2[0]);
            int end = int.Parse(input2[1]);

            int sum = prefixSum[end] - prefixSum[start - 1];
            sb.AppendLine(sum.ToString());
        }

        sw.Write(sb);
        sw.Flush();
    }
}
