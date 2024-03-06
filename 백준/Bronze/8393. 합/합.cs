StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int a = int.Parse(sr.ReadLine());
int result = 0;
for (int i = a; i > 0; i--)
{
    result += i;
}
sw.WriteLine(result);


sw.Close();
sr.Close();


