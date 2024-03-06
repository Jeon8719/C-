StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
int[] b = new int[10001];
for (int i = 0; i < a; i++)
{
    b[int.Parse(sr.ReadLine())]++;
}
for (int i = 0; i <= 10000; i++)
{
    if (b[i] != 0)
    {
        for (int j = 0; j < b[i]; j++)
        {
            sw.WriteLine(i);
        }
    }
}
sr.Close();
sw.Close();