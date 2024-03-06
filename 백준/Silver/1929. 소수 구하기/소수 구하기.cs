using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();

        int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
       for(int i = a[0]; i < a[1]+1; i++)
        {
            int result = FindNextPrime(i);
            if (result != 0)
            {
                sb.AppendLine(result.ToString());
            }
        }
        sw.WriteLine(sb.ToString());
        sw.Close();
        sr.Close();
       
    }

    static int FindNextPrime(int n)
    {
        if (n < 2) return 0; // 예외 처리: 2는 최소 소수
        else
        {
            if (IsPrime(n) != false)
            {
                return n;
            }
            else return 0;
        }



    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
