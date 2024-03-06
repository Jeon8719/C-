char[] a = Console.ReadLine().ToCharArray();
char[] b = a.Reverse().ToArray();
bool c = true;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] != b[i]) c = false;
}
if (c == true)
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(0);
}
