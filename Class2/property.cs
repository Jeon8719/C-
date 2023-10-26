class Person
{
    private string? name;
    public string Name//property
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public void SetName(string? name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return this.name;
    }


}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.SetName("손흥민");
        string call = person.GetName();
        Console.WriteLine(call);


        Multi("A");
        Multi("A", "B");
        Multi("A", "B", "C");
    }

    static void Multi(params string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == (arr.Length - 1)) Console.Write($"{arr[i]}");
            else Console.Write($"{arr[i]}+");
        }
        Console.WriteLine();





    }
}

