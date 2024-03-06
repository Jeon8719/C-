string[] a = Console.ReadLine().Split();
int b = int.Parse(a[0].Reverse().ToArray());
int c = int.Parse(a[1].Reverse().ToArray());
if (b>c) Console.WriteLine(b);
else Console.WriteLine(c);