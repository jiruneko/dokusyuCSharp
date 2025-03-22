internal class ScopeBasic
{
    public string data = "フィールド";

    // public string Show()
    // {
    //     string data = "ローカル";
    //     return data;
    // }

    // static void Main(string[] args)
    // {
    //     var s = new ScopeBasic();
    //     Console.WriteLine(s.Show());
    //     Console.WriteLine(s.data);
    // }

    // string Show()
    // {
    //     string data = "ローカル";
    //     return this.data;
    // }

    // static void Main(string[] args)
    // {
    //     var s = new ScopeBasic();
    //     Console.WriteLine(s.data);
    //     Console.WriteLine(s.Show());
    // }
    static void Main(string[] args)
    {
        var msg = "Local Variable";

        void MyLocal()
        {
            var msg = "inner Valiable";
            Console.WriteLine(msg);
        }
        MyLocal();
        Console.WriteLine(msg);
    }
}