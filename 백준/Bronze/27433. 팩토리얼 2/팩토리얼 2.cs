int N = int.Parse(Console.ReadLine());
Console.WriteLine(Fact(N));
long Fact(int N)
{
    long A = 1;
    while (N > 1)
    {
        A *= N;
        N= N - 1;
    }
    return A;
}