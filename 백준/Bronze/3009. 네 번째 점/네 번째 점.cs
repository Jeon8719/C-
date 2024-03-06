int[] a = new int[3];
int[] b = new int[3];
for (int i = 0; i < 3; i++)
{
    int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    a[i] = c[0];
    b[i] = c[1];
}
int d = 0;
int e = 0;
if (a[0] == a[1] && a[0] != a[2]) d = a[2];
else if (a[0] != a[1] && a[0] != a[2]) d = a[0];
else d = a[1];
if (b[0] == b[1] && b[0] != b[2]) e = b[2];
else if (b[0] != b[1] && b[0] != b[2]) e = b[0];
else e = b[1];
Console.WriteLine(d + " " + e);