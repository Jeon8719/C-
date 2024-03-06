char[][] A = new char[5][];

for (int i = 0; i < 5; i++)
{
    char[] a = Console.ReadLine().ToCharArray();
    A[i] = a;
}
for (int j = 0; j < 15; j++)
{
    for (int i = 0; i < 5; i++)
    {
        if (A[i].Length > j) Console.Write(A[i][j]);
    }
}
