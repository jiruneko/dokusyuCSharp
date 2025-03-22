internal class Figure
{
    public static double Pi = 3.14;
    public static void GetCircleArea(double r)
    {
        Console.WriteLine($"円の面積は{r * r * Pi}");
    }
}

internal class StaticBasic
{
    static void Main(string[] args)
    {
        Console.WriteLine(Figure.Pi);
        Figure.GetCircleArea(5);
    }
}