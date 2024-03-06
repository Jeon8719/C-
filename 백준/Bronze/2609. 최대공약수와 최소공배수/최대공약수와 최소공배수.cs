int[] N = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int A = GCD(N[0], N[1]);
int B = (N[0] / A) * (N[1] / A) * A;
Console.WriteLine(A);
Console.WriteLine(B);
int GCD (int a, int b)
{
    while (b != 0)
    {
        int c = b;
        b = a % b;
        a = c;
    }
    return a;
}