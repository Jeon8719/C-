string a = Console.ReadLine().ToUpper();
char[] b = new char[26];
for (int i = 0; i < b.Length; i++)
{
    b[i] = Convert.ToChar(65 + i);
}
int[] c = new int[26];
for (int i = 0; i < c.Length; i++)
{
    c[i] = a.Where(x => x.Equals(b[i])).Count();
}
int d = c.Where(x => x.Equals(c.Max())).Count();
if (d >= 2)
{
    Console.WriteLine("?");
}
else
{
    Console.WriteLine(b[Array.IndexOf(c, c.Max())]);
}
