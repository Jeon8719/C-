using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();

        int t = int.Parse(sr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int h = input[0];
            int w = input[1];
            int n = input[2];

            int floor = n % h;
            int room = n / h + 1;

            if (floor == 0)
            {
                floor = h;
                room -= 1;
            }

            sb.AppendLine($"{floor * 100 + room}");
        }

        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
    }
}
