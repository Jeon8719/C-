using System.Text;

StringBuilder sb = new StringBuilder();
int a = int.Parse(Console.ReadLine());
for(int i = 0; i < a; i++)
{
    int b = int.Parse(Console.ReadLine());
    int A = b / 25;
    int B = (b % 25) / 10;
    int C = ((b % 25) % 10) / 5;
    int D = ((b % 25) % 10) % 5;
    sb.AppendLine($"{A} {B} {C} {D}");
}
Console.Write( sb.ToString() );