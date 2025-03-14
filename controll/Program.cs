// var i = 10;
// if (i == 10)
// {
//     Console.WriteLine("変数iは10です。");
// }
// else
// {
//     Console.WriteLine("変数iは10ではありません。");
// }

// var i = 1;
// var j = 0;
// if (i == 1)
// {
//     if (j == 1)
//     {
//         Console.WriteLine("変数i、jは1です。");
//     }
//     else
//     {
//         Console.WriteLine("変数iは1ですが、jは1ではありません。");
//     }
// }
// else
// {
//     Console.WriteLine("変数iは1ではありません。");
// }

// var i = 1;
// if (i == 1)
//     Console.WriteLine("変数iは1です。");
// else
//     Console.WriteLine("変数iは1ではありません。");

// var i = 1;
// var j = 0;
// if (i == 1)
//     if (j == 1)
//         Console.WriteLine("変数i、jは1です。");
//     else
//         Console.WriteLine("変数iは1ではありません。");

var rank = "甲";

if (rank == "甲")
{
    Console.WriteLine("大変良いです。");
}
else if (rank == "乙")
{
    Console.WriteLine("良いです。");
}
else if (rank == "丙")
{
    Console.WriteLine("頑張りましょう。");
}
else
{
    Console.WriteLine("？？？");
}

var rank2 = "乙";

switch (rank2)
{
    case "甲":
        Console.WriteLine("大変良いです。");
        break;

    case "乙":
        Console.WriteLine("良いです。");
        break;

    case "丙":
        Console.WriteLine("頑張りましょう。");
        break;

    default:
        Console.WriteLine("???");
        break;
}

var drink = "ビール";
switch (drink)
{
    case "日本酒":
    case "ビール":
    case "ワイン":
        Console.WriteLine("醸造酒です。");
        break;
    case "ブランデー":
    case "ウイスキー":
        Console.WriteLine("蒸留酒です。");
        break;
}

object obj = -123;
switch (obj)
{
    case int i:
        Console.WriteLine(Math.Abs(i));
        break;
    case string str:
        Console.WriteLine(str[0]);
        break;
    default:
        Console.WriteLine("意図しない型です。");
        break;
}