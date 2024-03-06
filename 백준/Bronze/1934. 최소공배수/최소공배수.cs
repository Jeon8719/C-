using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int a = int.Parse(Console.ReadLine());
        for(int i  = 0; i < a; i++)
        {
            int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int num1 = b[0];
            int num2 = b[1];
            int result = EuclideanGCD(num1, num2);
            sb.AppendLine((Math.Abs(b[0] * b[1]) / result).ToString());
        }
        // 예시
        Console.WriteLine(sb.ToString());

    }

    static int EuclideanGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
