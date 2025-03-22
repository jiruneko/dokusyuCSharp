internal class Person
{
    public string firstName;
    public string lastName;

    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    // コンストラクター（引数を省略）
    public Person() : this("権兵衛", "名無しの") { }

    public void Show()
    {
        Console.WriteLine($"名前は{this.lastName}{this.firstName}です。");
    }
}

internal class ConstructorBasic
{
    static void Main(string[] args)
    {
        var p = new Person();
        p.Show();
    }
}