int[] a = new int[3];
int b = 0;
for (int i = 0; i < 3; i++)
{
    a[i] = int.Parse(Console.ReadLine());
    b += a[i];
}
if (b == 180)
{
    if (a[0] == a[1] && a[1] == a[2]) Console.WriteLine("Equilateral");
    else if (a[0] != a[1] && a[1] != a[2] && a[0] != a[2]) Console.WriteLine("Scalene");
    else Console.WriteLine("Isosceles");
}
else
{
    Console.WriteLine("Error");
}
