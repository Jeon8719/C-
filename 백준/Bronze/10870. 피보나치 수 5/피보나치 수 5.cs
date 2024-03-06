class Program
{
    static int N;
    static int[] s_memo = new int[25];
    static void Main(string[] args)
    {
        s_memo[0] = 0;
        s_memo[1] = 1;
        N = int.Parse(Console.ReadLine());
        Console.WriteLine(Fibo2(N));

    }


    static int Fibo2(int n)
    {
        if (n < 2)
        {
            return s_memo[n];
        }
        if (s_memo[n] != 0)
        {
            return s_memo[n];
        }
        return s_memo[n] = Fibo2(n - 1) + Fibo2(n - 2);
    }
}