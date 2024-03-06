int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
bool mixed = false;
int b = 8;
if (a[0] == 1)
{
    for (int i = 0; i < 8; i++)
    {
        if (a[i] != i + 1)
        {
            mixed = true;
            break;
        }
    }
    if (!mixed) Console.WriteLine("ascending");
    else Console.WriteLine("mixed");
}
else if (a[0] == 8)
{
    foreach(int i in a)
    {
        
        if( i != b)
        {
            mixed = true;
            break;
        }
        b--;
    }    
    if (!mixed) Console.WriteLine("descending");
    else Console.WriteLine("mixed");
}
else Console.WriteLine("mixed");

