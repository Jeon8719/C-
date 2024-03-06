int N = int.Parse(Console.ReadLine());
string num = (Console.ReadLine());
char[] arr = num.ToCharArray();
int result = 0;
for (int i = 0; i < arr.Length; i++)
{
    result += int.Parse(arr[i].ToString());
    
}
Console.WriteLine(result);