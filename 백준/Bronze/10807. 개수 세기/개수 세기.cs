int N = Convert.ToInt32(Console.ReadLine());
int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int V = Convert.ToInt32(Console.ReadLine());
int result = Array.FindAll(input, x => x == V).Length;
Console.WriteLine(result);
