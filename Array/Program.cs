// int[] data;
// data = new[] { 1, 2, 3, 4, 5 };
// Console.WriteLine(data[0]);



// int[] data = { 1, 2, 3, 4, 5 };
// data[4] = 6;
// data[1] = 15;
// Console.WriteLine(data[0..4]);

int[,] data = {
    {10, 11, 12},
    {20, 21, 22},
};
Console.WriteLine(data[0, 1]);

var multi = new[,] {
    {10,11,12},
    {20,21,22},
    {33,34,35},
};

Console.WriteLine(multi.Length);

var jagged = new int[3][];
jagged[0] = new[] { 10, 11, 12, 13 };
jagged[1] = new[] { 20, 21 };
jagged[2] = new[] { 30, 31, 32 };

Console.WriteLine(jagged);