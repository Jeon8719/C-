using System.Linq;
string str = Convert.ToString(Console.ReadLine());

var strResult = str.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
string Result = new String(strResult.ToArray());

Console.WriteLine(Result);