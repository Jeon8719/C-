using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            int K = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int[,] KN = new int[K + 1, N];

            for (int k = 0; k <= K; k++)
            {
                for (int n = 0; n < N; n++)
                {
                    if (k == 0)
                    {
                        KN[k, n] = n + 1;
                    }
                    else if (n == 0)
                    {
                        KN[k, n] = 1;
                    }
                    else
                    {
                        KN[k, n] = KN[k - 1, n] + KN[k, n - 1];
                    }
                }

            }

            sb.AppendLine($"{KN[K, N - 1]}");
        }

        Console.WriteLine(sb.ToString());
    }
}
