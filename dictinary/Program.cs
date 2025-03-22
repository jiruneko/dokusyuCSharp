var sd = new SortedDictionary<string, string>()
{
    ["Rose"] = "バラ",
    ["Sunflower"] = "ひまわり",
    ["Morning Glory"] = "あさがお"
};

foreach (var key in sd.Keys)
{
    Console.WriteLine($"{key}:{sd[key]}");
}

var dic = new Dictionary<string, string>()
{
    ["lettuce"] = "レタス",
    ["spinach"] = "ホウレンソウ",
    ["cucumber"] = "キュウリ"
};
dic["cucumber"] = "胡瓜";
dic.Add("cabbage", "キャベツ");
dic.Remove("spinach");
foreach (var m in dic)
{
    Console.WriteLine($"{m.Key}:{m.Value}");
}