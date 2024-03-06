int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = NM[0];
int M = NM[1];
int[][] A = new int[N][];
int[][] B = new int[N][];
for (int i = 0; i < N; i++)
{
    int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    A[i] = a;
}
for (int i = 0; i < N; i++)
{
    int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    B[i] = a;
}
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        Console.Write(A[i][j] + B[i][j] + " ");
    }
    Console.WriteLine();
}
