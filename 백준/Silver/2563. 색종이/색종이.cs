int[,] A = new int[100, 100];
int c = 0;
int a = int.Parse(Console.ReadLine());
for(int i = 0; i < a; i++)
{
    int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for( int j = b[0]; j < b[0] +10; j++)
    {
        for(int k = b[1]; k < b[1] + 10; k++)
        {
            if (A[j, k] == 0)
            {
                A[j, k] = 1;
                c++;
            }
        }
    }
}
Console.WriteLine(c);