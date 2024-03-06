int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine((a[0] + a[1]) % a[2]);
Console.WriteLine(((a[0] % a[2]) + (a[1] % a[2])) % a[2]);
Console.WriteLine((a[0] * a[1]) % a[2]);
Console.WriteLine(((a[0] % a[2]) * (a[1] % a[2])) % a[2]);
