class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<Meeting> meetings = new List<Meeting>();

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int start = int.Parse(input[0]);
            int end = int.Parse(input[1]);
            meetings.Add(new Meeting(start, end));
        }

        // 회의 종료 시간을 기준으로 정렬
        meetings.Sort();

        int count = 0;
        int endTime = 0;

        foreach (Meeting meeting in meetings)
        {
            if (meeting.Start >= endTime)
            {
                count++;
                endTime = meeting.End;
            }
        }

        Console.WriteLine(count);
    }
}

class Meeting : IComparable<Meeting>
{
    public int Start { get; set; }
    public int End { get; set; }

    public Meeting(int start, int end)
    {
        Start = start;
        End = end;
    }

    // 종료 시간을 기준으로 정렬하기 위한 CompareTo 메서드 구현
    public int CompareTo(Meeting other)
    {
        if (End == other.End)
        {
            return Start.CompareTo(other.Start);
        }
        return End.CompareTo(other.End);
    }
}
