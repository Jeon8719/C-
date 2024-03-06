var grade = new Dictionary<string, double>
{
    { "A+", 4.5 },
    { "A0", 4.0 },
    { "B+", 3.5 },
    { "B0", 3.0 },
    { "C+", 2.5 },
    { "C0", 2.0 },
    { "D+", 1.5 },
    { "D0", 1.0 },
    { "F", 0.0 }
};
double answer = 0;
double score = 0;
for (int i = 0; i < 20; i++)
{
    string[] a = Console.ReadLine().Split();
    double value;
    
    if (grade.TryGetValue(a[2], out value))
    {
        answer += double.Parse(a[1]) * value;
        score += double.Parse(a[1]);
    }
}
Console.WriteLine(answer/score);




