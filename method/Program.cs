using System;

internal class Person
{
    public string firstName = "";
    public string lastName = "";

    public string Show()
    {
        return $"名前は{this.lastName}{this.firstName}です。";
    }
}

// class Program
// {
//     static void Main()
//     {
//         var p = new Person();
//         p.firstName = "太郎";
//         p.lastName = "山田";
//         Console.WriteLine(p.Show());
//     }
// }

class Program2
{
    static void Main()
    {
        double Discount(int price, double rate)
        {
            return price * (1 - rate);
        }
        Console.WriteLine(Discount(1000, 0.2));
    }
}