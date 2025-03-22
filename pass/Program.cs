﻿// internal class PassBasic
// {
//     public int CountUp(int data)
//     {
//         data++;
//         return data;
//     }

//     static void Main(string[] args)
//     {
//         var data = 1;
//         var p = new PassBasic();
//         Console.WriteLine(p.CountUp(data));
//         Console.WriteLine(data);
//     }
// }

internal class PassArray
{
    public int[] Update(int[] data)
    {
        data = new[] { 10, 20, 30 };
        return data;
    }

    static void Main(string[] args)
    {
        var data = new[] { 2, 4, 6 };
        var p = new PassArray();
        Console.WriteLine(p.Update(data)[0]);
        Console.WriteLine(data[0]);
    }
}