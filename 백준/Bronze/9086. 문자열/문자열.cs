int a = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < a; i++)
{
    string b = Convert.ToString(Console.ReadLine());
    Console.Write(b.Substring(0,1));
    Console.WriteLine(b.Substring(b.Length-1, 1));
}