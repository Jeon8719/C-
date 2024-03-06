StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int a = int.Parse(sr.ReadLine());
int[] b = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
sw.WriteLine($"{b.Min()} {b.Max()}");
sw.Close();
sr.Close();