StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int[] b = new int[10];
for (int i = 0; i < 10; i++)
{
    int a = int.Parse(sr.ReadLine());
    b[i] = a % 42;
    
}
var result = b.GroupBy(x => x).Where(g => g.Count() > 0).Select(y => y.Key).ToList();
sw.WriteLine(result.Count);
sw.Close();
sr.Close();