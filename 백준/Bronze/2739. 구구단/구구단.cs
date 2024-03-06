using System;

    class Program
    {
 static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{N} * {i} = {N * i}");
            }
        }
    }