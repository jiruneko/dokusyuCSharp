internal class IteratorBasic
{
    public IEnumerable<string> GetString()
    {
        yield return "あいうえお";
        yield return "かきくけこ";
        yield return "さしすせそ";
    }

    static void Main(string[] args)
    {
        var ite = new IteratorBasic();
        foreach (var str in ite.GetString())
        {
            Console.WriteLine(str);
        }
    }
}