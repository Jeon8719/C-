using System;
class Car
{
    private string? _name;
    public Car() : this("승용차") { }
    public Car(string? name)
    {
        _name = name;
    }
    ~Car()//소멸자
    {
        Console.WriteLine("폐차");
    }
    public string? GetName()
    {
        return _name;
    }
}
class Money
{
    public Money() : this(1000)
    {

    }
    public Money(int money)
    {
        Console.WriteLine($"Money : {money:#,###}");
    }

}
class Monster
{
    private string _name;

    public Monster() : this("인간")
    {

    }
    public Monster(string name)
    {
        Console.WriteLine("게임이 시작 되었다.");
        _name = name;
        Console.WriteLine($"{name} 유닛이 생성되었다.");
    }
    public string? GetName()
    { return _name; }
}
class Say
{
    private string message;
    public Say() : this("안녕하세요") { }//동일한 구조체 호출 (매서드 포워드)
    public Say(string message)
    {
        this.message = message;
        Console.WriteLine($"{this.message}");
    }
}
class Person
{
    private string name;
    public Person() : this("홍길동") { }

    public Person(string name)
    {
        this.name = name;
    }
    public string? GetName()
    {
        return name;
    }

}
class Circle
{
    private double radius;
    public Circle(double radius) //생성자 초기화
    {
        this.radius = radius;

    }
    public double GetArea() //반환자 호출
    {
        return Math.PI * Math.Pow(radius, 2);
    }


}
class Dog
{
    private string? name;
    public Dog(string name)
    {
        this.name = name;
    }
    public void Bark() => Console.WriteLine($"{this.name} 멍멍멍");
}
class First : Object
{
    public override string ToString()
    {
        return "새로 정의된 매서드";
    }
}
class StaticAnd
{
    public static void StaticFun() => Console.WriteLine("Static method");
    public void InstanceFun() => Console.WriteLine("Instance method");
    //static 포함 여부에 따라 호출 방식이 다르다.
}
class Student
{
    //필드 생성 (필드값은 비공개)
    private string name;
    private int age;
    public Student()
    {
        this.name = "임꺽정";
        this.age = 19;
    }
    //생성자 : Class 명과 public 명을 같게.
    ///get,set 등을 활용하여 필드값을 꺼내쓴다.
    public Student(string name, int age) 
    {
        Console.WriteLine("생성자 호출");
        this.name = name;
        this.age = age;
    }
    public void CallName() => Console.WriteLine($"{this.name}을 호출");
}
class Program
{
    static void Call_car()
    {
        Car car1 = new Car();
        Console.WriteLine();
        Car car2 = new Car("캠핑카");
        Console.WriteLine(car2.GetName());

    }
    static void Main()
    {
        Student student = new Student("홍길동", 31);
        student.CallName();
        
        Student student1 = new Student();
        student1.CallName();

        StaticAnd.StaticFun();

        StaticAnd staticAnd = new StaticAnd();
        staticAnd.InstanceFun();

        First first = new First();
        Console.WriteLine(first.ToString());

        Dog dog = new Dog("바둑이");
        dog.Bark();

        Console.WriteLine("반지름을 입력하세요:\b\b");
        double R = Convert.ToDouble(Console.ReadLine());
        Circle circle = new Circle(R);
        Console.WriteLine($"넓이: {circle.GetArea():f2}");

        var person = new Person();
        Console.WriteLine(person.GetName());
        Console.WriteLine("=========================");
        var person2 = new Person("이순신");
        Console.WriteLine(person2.GetName());

        var say = new Say();
        Console.WriteLine("=========================");
        new Say("좋은 아침입니다.");

        Monster monster = new Monster("마린");
        Console.WriteLine($"{monster.GetName()} 유닛이 소멸되었습니다");

        new Money();
        new Money(2000);

        Call_car();
        GC.Collect();
        Console.ReadLine();
    }
}

 
    