using System;
class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 10; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
        }
        //피라미드 모양 뽑기
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 9; j >= i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * (i - 1) + 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

}