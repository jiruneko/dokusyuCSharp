using System;

class Person
{
    public string firstName { get; set; }
    public string lastName { get; set; }
}

class Program
{
    static void Main()
    {

        var p1 = new Person();
        p1.firstName = "太郎";
        p1.lastName = "山田";

        var p2 = new Person();
        p2.firstName = "花子";
        p2.lastName = "鈴木";

        Console.WriteLine($"{p1.lastName}{p1.firstName}");
        Console.WriteLine($"{p2.lastName}{p2.firstName}");
    }
}