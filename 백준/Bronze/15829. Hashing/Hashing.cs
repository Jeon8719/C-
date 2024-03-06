int L = int.Parse(Console.ReadLine());
char[] chars = Console.ReadLine().ToCharArray();
long m = 1234567891;
long sum = 0;
for (int i = 0; i < L; i++)
{
    long num = chars[i] - 'a' + 1;
    long mul = 1;
    for (int j = 0; j < i; j++)
    {
        mul *= 31;
        mul %= m;
    }

    sum += num * mul;
    sum %= m;
     
}
Console.WriteLine(sum);
