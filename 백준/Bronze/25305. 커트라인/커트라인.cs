int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(b);//76 85 93 98 100
int[] c = b.Reverse().ToArray();
Console.WriteLine(c[a[1]-1]);