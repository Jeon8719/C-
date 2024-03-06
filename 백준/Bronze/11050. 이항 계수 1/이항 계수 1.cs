int[] N = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int A = 1; int B = 1; int C = 1;
for (int i = N[0]; i > 0; i--)
{
    A *= i;
}
for (int i = N[0] - N[1]; i > 0;i--)
{
    B *= i;
}
for (int i = N[1]; i > 0; i--)
{
    C *= i;
}
Console.WriteLine(A/(B*C));
