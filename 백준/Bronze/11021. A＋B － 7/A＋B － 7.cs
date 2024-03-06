StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int a = int.Parse(sr.ReadLine());
int result = 0;
for (int i = 0; i < a; i++)
{
    int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    result = b[0] + b[1];

    sw.WriteLine($"Case #{i+1}: {result}");
}
sw.Close();
sr.Close();