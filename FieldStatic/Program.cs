// エラー↓
internal class MyApp
{
    public static readonly string Title = "独習C#";
}
internal class FieldStatic
{
    static void Main(string[] args)
    {
        Console.WriteLine(MyAppTitle);
        MyApp.Title = "本気でおぼえるC#";
    }
}

public const string Title = "独習C#";
