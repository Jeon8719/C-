string[] input = Console.ReadLine().Split();
int a = input.Count();
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == "") a--;
}
Console.WriteLine(a);

