// int i;
// int sum = 0;

// for (i = 1; i <= 100; i++)
// {
//     sum += i;
//     if (sum > 1000)
//     {
//         break;
//     }
// }

// Console.WriteLine($"合計が1000を超えるのは、1〜{i}を加算した時です。");

// goto THERE;
// Console.WriteLine("ここはスキップされます。");

// THERE:

// Console.WriteLine("コードが終了しました。");

for (var i = 1; i < 10; i++)
{
    for (var j = 1; j < 10; j++)
    {
        var result = i * j;
        if (result > 40)
        {
            goto END;
        }
        Console.Write($"{result,2}");
    }
    Console.WriteLine();
}

END:
Console.WriteLine("終了しました。");

var rank = "甲";

switch (rank)
{
    case "甲":
        Console.WriteLine("大変良いです。");
        goto case "丙";
    case "乙":
        Console.WriteLine("良いです。");
        goto case "丙";
    case "丙":
        Console.WriteLine("合格です。");
        break;
    case "丁":
        Console.WriteLine("頑張りましょう。");
        break;
    default:
        Console.WriteLine("???");
        break;
}