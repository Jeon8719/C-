StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int a = int.Parse(sr.ReadLine());
char c = '(';
char d = ')';
for (int i = 0; i < a; i++)
{
    string b = sr.ReadLine();
    int e = b.Count(g => (g == c));
    int f = b.Count(g => (g == d));
    if (e == f)
    {
        int count = 0;
        foreach (char g in b)
        {
            if (g == '(') count++;
            else count--;
            if (count < 0)
            {
                sw.WriteLine("NO"); break;

            } 
        }
        if (count == 0) sw.WriteLine("YES");

    }
    else
        sw.WriteLine("NO");
}
sw.Close();
sr.Close();
