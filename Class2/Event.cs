class Champion
{
    int _hp = 100;
    public int Hp
    {
        get => _hp;
        set 
        {
            _hp = value;
            OnHpChanged?.Invoke(_hp);
            OnHpChangedEvent?.Invoke(_hp);
        }

    }
    public Action<int> OnHpChanged;
    public event Action<int> OnHpChangedEvent;
}
class Slider
{
    public void ChangeValue(int value)
    {
        Console.WriteLine(value);
    }
}
class Program
{


    static void Main()
    {
        Champion nautilus = new();
        Slider slider = new();
        nautilus.OnHpChanged += slider.ChangeValue;
        nautilus.OnHpChangedEvent += slider.ChangeValue;
        nautilus.OnHpChanged?.Invoke(10);


    }

}
