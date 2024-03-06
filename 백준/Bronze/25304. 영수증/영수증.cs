StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int a = int.Parse(sr.ReadLine());
int b = int.Parse(sr.ReadLine());
int result = 0;
for (int i = 0; i < b; i++)
{
    int[] c = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    result += c[0] * c[1];
}
if (result == a)
{
    sw.WriteLine("Yes");
}
else
{
    sw.WriteLine("No");
}


sw.Close();
sr.Close();


