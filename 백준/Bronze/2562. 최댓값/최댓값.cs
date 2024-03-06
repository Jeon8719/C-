StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int[] b = new int[9];
for (int i = 0; i < 9; i++)
{
    int a = int.Parse(sr.ReadLine());
    b[i] = a;
}
sw.WriteLine(b.Max());
for (int i = 0;i < 9; i++)
{
    if (b[i] == b.Max()) sw.WriteLine(i+1);
}
sw.Close();
sr.Close();


