int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a * ((b % 100)%10));
Console.WriteLine(a * ((b % 100)/10));
Console.WriteLine(a * (b / 100));
Console.WriteLine(a * b);
