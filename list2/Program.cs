var s = new Stack<int>();
s.Push(10);
s.Push(15);
s.Push(30);
s.Push(60);

foreach (var v in s)
{
    Console.WriteLine(v);
}

Console.WriteLine(s.Count());
Console.WriteLine(s.Contains(30));
Console.WriteLine(s.Pop());
Console.WriteLine(s.Peek());
Console.WriteLine(s.Pop());

Console.WriteLine(String.Join(",", s.ToArray()));

var list = new Queue<int>();
list.Enqueue(10);
list.Enqueue(15);
list.Enqueue(30);
list.Enqueue(60);

foreach (var v in list)
{
    Console.WriteLine(v);
}
Console.WriteLine(list.Count());
Console.WriteLine(list.Contains(30));
Console.WriteLine(list.Dequeue());
Console.WriteLine(list.Peek());
Console.WriteLine(list.Dequeue());

Console.WriteLine(string.Join(",", list.ToArray()));