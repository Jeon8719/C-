int[] a= Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
bool d = false;
for(int i = c; i < 101; i++)
{
    if (a[0] * i + a[1] <= b * i)
    {
        d = true;
    }
    else
    {
        d = false;
        break;
    }
}
if (d == false)
{
    Console.WriteLine(0);
}
else Console.WriteLine(1);