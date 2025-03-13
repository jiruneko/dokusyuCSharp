using System;

namespace SelfCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 17320.5e-5;
            var str = "You are \"Great\" teacher";
            Console.WriteLine(str);
            Console.WriteLine(i);
            Console.WriteLine(@"You are ""GREAT"" teacher!!");
        }
    }
}