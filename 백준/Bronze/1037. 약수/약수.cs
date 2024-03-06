int N = int.Parse(Console.ReadLine());
int[] M = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
Array.Sort(M);
int A = M.First() * M.Last();
Console.WriteLine(A);