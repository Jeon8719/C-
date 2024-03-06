int A = Convert.ToInt32(Console.ReadLine());
int answer = 1; 
for (int i = A; i >= 2; i--)
{
    answer *= i;
}
Console.WriteLine(answer);