StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());
int a = int.Parse(sr.ReadLine());
string result = "";
for (int i = 0; i < (a/4)-1; i++)
{
    if (a/4 != 1) result += "long ";
     
}
result += "long int";
sw.WriteLine(result);

sw.Close();
sr.Close();