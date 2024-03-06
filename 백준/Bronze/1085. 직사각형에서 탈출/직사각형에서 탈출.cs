int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = Math.Min(a[0], a[2]);
int c = Math.Min(a[1], a[3]);
int d = Math.Min(Math.Abs(a[0] - a[2]),Math.Abs(a[1]- a[3]));
List<int> result = new List<int>();
result.Add(b);
result.Add(c);
result.Add(d);
Console.WriteLine(result.Min());