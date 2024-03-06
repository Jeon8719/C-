StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));
char[] a = sr.ReadLine().ToCharArray();
Array.Sort(a);
Array.Reverse(a);
for(int i = 0; i < a.Count(); i++)
{
    sw.Write(a[i]);
}
sr.Close();
sw.Close();