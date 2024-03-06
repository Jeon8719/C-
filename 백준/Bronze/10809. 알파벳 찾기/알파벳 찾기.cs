string num = (Console.ReadLine());
char[] arr = num.ToCharArray();
char[] arlpa = new char[26];
for(int i = 0; i < arlpa.Length; i++)
{
    arlpa[i] = Convert.ToChar(97+i);
}
for (int i = 0; i < arlpa.Length; i++)
{
    Console.Write(Array.IndexOf(arr, arlpa[i]));  
    Console.Write(" ");
}
