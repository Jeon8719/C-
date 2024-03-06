using System.Text;

class Program
{
    static void Main()
    {
        StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
        StringBuilder sb = new StringBuilder();
        double[] b = Array.ConvertAll(sr.ReadLine().Split(), double.Parse);
        double num1 = b[0];
        double num2 = b[1];
        double result = EuclideanGCD(num1, num2);
        sb.Append((Math.Abs(b[0] * b[1]) / result).ToString());
        sw.WriteLine(sb.ToString());
        sr.Close();
        sw.Close();
    }
    
    static double EuclideanGCD(double a, double b)
    {
        while (b != 0)
        {
            double temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
