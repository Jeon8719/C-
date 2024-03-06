int T = int.Parse(Console.ReadLine());
for (int i = 0; i < T; i++)
{
    string[] input = Console.ReadLine().Split();
    int R = int.Parse(input[0]);
    char[] S = input[1].ToCharArray();
    for (int j = 0; j < S.Length; j++)
    {
        int n = R;
        while (n-- > 0)
        {
            Console.Write(S[j]);
        }   
    }
    Console.WriteLine();
}

