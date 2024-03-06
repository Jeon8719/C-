string a = Console.ReadLine();
int b = 0;
int c = 666;

while (true)
{
    if (Convert.ToString(c).Contains("666"))
    {
        b++;
    }
    if(int.Parse(a) == b)
    {
        break;
    }
    c++;
}
Console.WriteLine(c);