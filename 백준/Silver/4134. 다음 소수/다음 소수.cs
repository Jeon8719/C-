using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();

        int testCases = int.Parse(sr.ReadLine());

        for (int t = 0; t < testCases; t++)
        {
            long n = long.Parse(sr.ReadLine());
            long result = FindNextPrime(n);
            sb.AppendLine(result.ToString());
        }

        sw.Write(sb.ToString());
        sr.Close();
        sw.Close();
    }

    static long FindNextPrime(long n)
    {
        if (n < 2) return 2; // 예외 처리: 2는 최소 소수

        while (!IsPrime(n))
        {
            n++;
        }

        return n;
    }

    static bool IsPrime(long num)
    {
        if (num < 2) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (long i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
