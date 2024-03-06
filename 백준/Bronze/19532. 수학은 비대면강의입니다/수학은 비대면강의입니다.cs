int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for(int x = -999;  x <= 999; x++)
{
    for(int y = -999; y <= 999; y++)
    {
        if (a[0]*x + a[1]*y == a[2] && a[3]*x + a[4]*y == a[5])
        {
            Console.WriteLine(x + " " + y);
            break;
        }
    }
}
    

