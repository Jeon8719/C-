using System.Text;

StringBuilder sb = new StringBuilder();
int T = int.Parse(Console.ReadLine());
int recursionCount = 0;
for (int i = 0; i < T; i++)
{    
    char[] s = Console.ReadLine().ToCharArray();
    sb.AppendLine(isPalindrome(s).ToString() + " " + recursionCount);
    recursionCount = 0;
}
Console.WriteLine(sb.ToString());

int recursion(char[] s, int l, int r)
{
    if (l >= r) return 1;
    else if (s[l] != s[r]) return 0;
    else
    {
        recursionCount++;
        return recursion(s, l + 1, r - 1);
    }
}
int isPalindrome(char[] s)
{
    recursionCount++;
    return recursion(s, 0, s.Length - 1);
}
