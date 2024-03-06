int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int b = (int)Math.Ceiling((double)(a[2] - a[1]) / (a[0] - a[1]));
Console.WriteLine(b);
// a[0] * x - a[1] * (x-1) = a[2]
// a[0]x - a[1]x + a[1] = a[2]
// a[0]x - a[1]x  = a[2] - a[1]
//(a[0] - a[1])x = a[2] - a[1]
// x=(a[2] - a[1])/(a[0] - a[1]) Math.Ceiling(d);//소수첫짜리 올림

/* 시간초과
while (true)
{
    b += a[0]; //2 3 4 5
    if (b >= a[2])
    {
        Console.WriteLine(c+1);
        break;
    }
    else
    {
        c++; //1 2 3 4 5 6
        b -= a[1];//1 2 3
    }
}
*/

