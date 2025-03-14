const double EPSILON = 0.00001;
double x = 0.2 * 3;
double y = 0.6;
Console.WriteLine(Math.Abs(x - y) < EPSILON);

var data1 = new[] { "い", "ろ", "は" };
var data2 = new[] { "い", "ろ", "は" };
Console.WriteLine(data1 == data2);
Console.WriteLine(data1.Equals(data2));

Console.WriteLine(data1.SequenceEqual(data2));

// var score = 75;
// Console.WriteLine(score >= 70 ? "合格！" : "不合格");

// string? str = "山田";
// string def = "権兵衛";
// Console.WriteLine(str ?? def);

string? str = null;
if (str != null && str.StartsWith("https://"))
{
    Console.WriteLine("「https://〜」で始まります。");
}