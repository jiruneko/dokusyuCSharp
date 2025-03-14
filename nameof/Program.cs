internal class NameOfBasic
{
    int data = 1;

    static void Main(string[] args)
    {
        Console.WriteLine(nameof(NameOfBasic));
        Console.WriteLine(nameof(data));
    }
}

// public void Hoge(string? str)
// {
//     if (str == null)
//     {
//         throw new ArgumentNullException("str");
//     }
// }