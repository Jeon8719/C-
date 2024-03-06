using System;

class Program
{
    static void Main()
    {
        int[] NMB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[,] NM = new int[NMB[0], NMB[1]];

        int min = 256;
        int max = 0;
        for (int i = 0; i < NMB[0]; i++)
        {
            int[] M = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < NMB[1]; j++)
            {
                NM[i, j] = M[j];
                if(min > M[j]) min = M[j];
                if(max < M[j]) max = M[j];
            }

        }

        int remove, build, time;
        int minTime = 256 * NMB[0] * NMB[1] * 2;
        int maxHeight = 0;
        for(int i = min; i <= max; i++)
        {
            remove = 0;
            build = 0;
            for (int x = 0; x < NMB[0]; x++)
            {
                for (int y = 0; y < NMB[1]; y++)
                {
                    int height = NM[x, y] - i;

                    if (height > 0)
                        remove += height;
                    else if (height < 0)
                        build -= height;
                }
            }
            if (build <= remove + NMB[2])
            {
                time = remove * 2 + build;

                if (time <= minTime)
                {
                    minTime = time;
                    maxHeight = i;
                }
            }
        }

        Console.WriteLine($"{minTime} {maxHeight}");
    }
}
