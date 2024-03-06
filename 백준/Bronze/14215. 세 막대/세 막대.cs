int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(a);
while (true)
{


    if (a[2] < a[0] + a[1])
    {
        Console.WriteLine(a[0] + a[1] + a[2]);
        break;
    }
    else
    {
        a[2]--;
    }

}


