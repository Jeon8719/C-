int[,,] d = new int[50, 50, 50];

while (true)
{
    int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    if (a[0] == -1 && a[1] == -1 && a[2] == -1)
        break;
    Console.WriteLine($"w({a[0]}, {a[1]}, {a[2]}) = {w(a[0], a[1], a[2])}");
}

int w(int a, int b, int c)
{
    if (a <= 0 || b <= 0 || c <= 0)
        return 1;
    if (a > 20 || b > 20 || c > 20)
        return w(20, 20, 20);
    if (d[a, b, c] != 0)
        return d[a, b, c];
    if (a < b && b < c)
        return d[a, b, c] = w(a, b, c - 1) + w(a, b - 1, c - 1) - w(a, b - 1, c);
    else
        return d[a, b, c] = w(a - 1, b, c) + w(a - 1, b - 1, c) + w(a - 1, b, c - 1) - w(a - 1, b - 1, c - 1);

}