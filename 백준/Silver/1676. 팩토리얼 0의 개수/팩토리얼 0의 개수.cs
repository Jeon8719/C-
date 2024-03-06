using System.Numerics;

int N = int.Parse(Console.ReadLine());

BigInteger f = 1;
for (int i = N; i > 0; i--)
{
    f *= i;
}
char[] A = f.ToString().ToCharArray();
A = A.Reverse().ToArray();

int count = 0;
for (int i = 0; i < A.Length; i++)
{
    if (A[i] == '0') count++;
    else break;
}
Console.WriteLine(count);