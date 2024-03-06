string a = Console.ReadLine();
string[] b = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
char[] c = a.ToCharArray();
int d = 0;

for (int i = 0; i < b.Length; i++)
{
    while (a.Contains(b[i]))
    {
        if (a.Contains(b[2]))
        {
            c[a.IndexOf(b[2])] = '0';
            c[a.IndexOf(b[2]) + 1] = '0';
            c[a.IndexOf(b[2]) + 2] = '0';
        }
        else
        {
            c[a.IndexOf(b[i])] = '0';
            c[a.IndexOf(b[i]) + 1] = '0';
        }
        d++;
        a = new string(c);
    }

}
for (int i = 0; i < c.Length; i++)
{
    if (c[i] != '0')
    {
        d++;
    }
}
Console.WriteLine(d);