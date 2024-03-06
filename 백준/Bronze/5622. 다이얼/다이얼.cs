char[] a = Console.ReadLine().ToCharArray();
int wait = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] <= 'C') wait += 3;
    else if (a[i] <= 'F') wait += 4;
    else if(a[i] <= 'I') wait += 5;
    else if(a[i] <= 'L') wait += 6;
    else if(a[i] <= 'O') wait += 7;
    else if(a[i] <= 'S') wait += 8;
    else if(a[i] <= 'V') wait += 9;
    else if(a[i] <= 'Z') wait += 10;
}
Console.WriteLine(wait);

