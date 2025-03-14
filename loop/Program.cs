var i = 1;
while (i < 6)
{
    Console.WriteLine($"{i}番目のループです。");
    i++;
}

var j = 1;
do
{
    Console.WriteLine($"{j}番目のループです。");
    j++;
}
while (j < 6);

var k = 1;
while (k < 6)
    Console.WriteLine(k++);
Console.WriteLine("----------");

for (var l = 1; l < 7; l++)
{
    Console.WriteLine($"{l}番目のループです。");
}

for (int m = 1, n = 1; m < 6; m++, n++)
{
    Console.WriteLine(m * n);
}

var data = new[] { "うめ", "さくら", "もも" };
foreach (var val in data)
{
    Console.WriteLine(val);
}